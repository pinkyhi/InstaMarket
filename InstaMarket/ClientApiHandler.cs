using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstaMarket.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace InstaMarket
{
    class TextOrder
    {
        public string Text { get; set; }
        public Model.Order Order { get; set; }
        public InstaMarketDbContext dbContext { get; set; }
        public TextOrder(string text, InstaMarketDbContext dbContext)
        {
            Text = text.Trim();
            this.dbContext = dbContext;
        }
        public bool TryToParse()
        {
            if (Text != null)
            {
                try
                {
                    string beforeStars = Text.Substring(0, Text.IndexOf('*'));
                    List<string> lfpdm = beforeStars.Split(',').ToList();
                    if (lfpdm.Count < 4 || lfpdm[0].Length<2 || lfpdm[1].Length<2 || Regex.Match(lfpdm[2], @"^(\+[0-9]{9})$").Success || dbContext.Deliveries.FirstOrDefault(d=>d.Delivery_Id==Convert.ToInt32(lfpdm[3]))==null)
                    {
                        return false;
                    }


                    string afterStars = Text.Substring(Text.LastIndexOf('*') + 1);
                    List<string> vas = afterStars.Split(',').ToList();

                    List<int> vendorCodes = vas.Select(va=>Convert.ToInt32(va.Substring(0,va.IndexOf('-')))).ToList();
                    List<int> amounts = vas.Select(va=>Convert.ToInt32(va.Substring(va.IndexOf('-')+1))).ToList();

                    if (vendorCodes.Count != amounts.Count || vendorCodes.Count==0)
                    {
                        return false;
                    }

                    Model.Order order = new Model.Order { Receipts = new List<Model.Receipt>(), Date = DateTime.Now };

                    order.Last_Name = lfpdm[0];
                    order.First_Name = lfpdm[1];
                    order.Phone_Number = lfpdm[2];
                    order.Delivery_Id = Convert.ToInt32(lfpdm[3]);
                    if(lfpdm.Count == 5)
                    {
                        order.Email = lfpdm[4];
                    }

                    for(int i = 0; i < vendorCodes.Count; i++)
                    {
                        if (amounts[i] < 1)
                        {
                            return false;
                        }
                        Model.Good_Dimension goodDimension = dbContext.Good_Dimensions.FirstOrDefault(gd => gd.Good_Dimension_Id == vendorCodes[i]);
                        if (goodDimension == null)
                        {
                            return false;
                        }
                        order.Receipts.Add(new Model.Receipt { Amount = amounts[i], Good_Dimension_Id = vendorCodes[i], Order = order, Position_Price = goodDimension.Price * amounts[i] });

                    }

                    order.Full_Price = order.Receipts.Sum(r => r.Position_Price);

                    Order = order;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
    public class ClientApiHandler
    {
        public IInstaApi instaApi { get; set; }
        public InstaMarketDbContext dbContext { get; set; }
        public int Timeout { get; set; }
        public bool isStarted { get; set; }
        public ClientApiHandler(ref IInstaApi InstaApi, ref InstaMarketDbContext dbContext, int timeout)
        {
            this.instaApi = InstaApi;
            this.dbContext = dbContext;
            Timeout = timeout;
        }
        public void Start()
        {
            isStarted = true;

            while (isStarted)
            {
                CheckPendingRequests();
                CheckComments();
                CheckInbox();
                Thread.Sleep(4000);

            }
        }
        public void Stop()
        {
            isStarted = false;
        }
        public async void CheckPendingRequests()
        {
            
            var pendingRequests = await instaApi.MessagingProcessor.GetPendingDirectAsync(PaginationParameters.MaxPagesToLoad(100));
            try
            {
                foreach (var x in pendingRequests.Value.Inbox.Threads)
                {
                    await instaApi.MessagingProcessor
                        .ApproveDirectPendingRequestAsync(x.ThreadId);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CheckComments()
        {
            
        }
        public async void CheckInbox()
        {
            
            var inbox = await instaApi.MessagingProcessor
                .GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(50));

            if (inbox.Succeeded && inbox.Value.Inbox.UnseenCount != 0)
            {
                foreach (InstaDirectInboxThread chat in inbox.Value.Inbox.Threads.Where(t => t.HasUnreadMessage))
                {
                    List<InstaDirectInboxItem> messagesToWork = new List<InstaDirectInboxItem>();
                    var threadWithMessages = await instaApi.MessagingProcessor
                        .GetDirectInboxThreadAsync(chat.ThreadId, PaginationParameters.MaxPagesToLoad(1));
                    if (threadWithMessages.Succeeded)
                    {
                        var myId = instaApi.GetLoggedUser().LoggedInUser.Pk;
                        threadWithMessages.Value.Items.Reverse();
                        messagesToWork = threadWithMessages.Value.Items.Where(m => m.UserId != myId).Take(1).ToList();
                    }
                    foreach (InstaDirectInboxItem item in messagesToWork)
                    {
                        if (dbContext.Chats.FirstOrDefault(c => c.Chat_Id == chat.ThreadId) == null)
                        {
                            dbContext.Chats.Add(new Model.Chat { Chat_Id = chat.ThreadId, User_Id = item.UserId, Chat_Status_Id = 1 });
                            dbContext.SaveChanges();
                        }
                        if (dbContext.Users.FirstOrDefault(u => u.User_Id == item.UserId) == null)
                        {
                            dbContext.Users.Add(new Model.User { User_Id = item.UserId, User_Name=chat.Title});
                            dbContext.SaveChanges();
                        }
                        if (item.ItemType == InstaDirectThreadItemType.MediaShare)
                        {

                            Model.Publication tp = dbContext.Publications.FirstOrDefault(p => p.Publication_Id == item.MediaShare.Pk);
                            List<Model.Good_Dimension> good_Dimensions = new List<Model.Good_Dimension>();

                            if (tp.Good_Dimension_Publications != null)
                            {
                                 good_Dimensions = new List<Model.Good_Dimension>(tp.Good_Dimension_Publications.Select(gdp => gdp.Good_Dimension));
                            }

                            string text = "Vendor codes in this post\n";
                            foreach (Model.Good_Dimension gd in good_Dimensions)
                            {
                                text += gd + "\nAvailable count: " + gd.Available +"\nPrice: " + gd.Price + "\nID: " + gd.Good_Dimension_Id + "\n";
                            }
                            text += "\n\n To make an order write \n/startOrder";

                            await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, text);
                        }
                        else if (item.ItemType == InstaDirectThreadItemType.Text || item.ItemType == InstaDirectThreadItemType.Link)
                        {
                            await instaApi.MessagingProcessor.MarkDirectThreadAsSeenAsync(chat.ThreadId, item.ItemId);
                            if (item.Text.Trim().ToLower().Equals("/startorder"))
                            {
                                string text = "Available delivery places\n";
                                List<Model.Delivery> dels = dbContext.Deliveries.OrderBy(d => d.City).ToList();
                                foreach (Model.Delivery del in dbContext.Deliveries)
                                {
                                    text += del.ToString() + "\n DeliveryID: " + del.Delivery_Id + "\n\n";
                                }
                                text += "\n\nTo make an order write the message in format:\n\nLastname,Firstname,Phone,DeliveryId,Email***Vendor codes that you would like to buy with count through dash, (separated by comma);\n\nExample:\n\nIvanov,Ivan,+380998765432,1,example@mail.com***1-7,6-1,32-1,2-3\n\nTo submit your order write\n/stopOrder";
                                await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, text);
                                dbContext.Chats.Find(chat.ThreadId).Chat_Status_Id = 2;
                                dbContext.SaveChanges();
                            }
                            else if (item.Text.Trim().ToLower().Equals("/stoporder"))
                            {
                                await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, "Order creating is stopped");
                                dbContext.Chats.Find(chat.ThreadId).Chat_Status_Id = 0;
                                dbContext.SaveChanges();
                            }
                            else if (dbContext.Chats.Find(chat.ThreadId).Chat_Status_Id == 1)
                            {
                                dbContext.Chats.Find(chat.ThreadId).Chat_Status_Id = 0;
                            }
                            else if(dbContext.Chats.Find(chat.ThreadId)!=null && dbContext.Chats.Find(chat.ThreadId).Chat_Status_Id==2)
                            {
                                TextOrder textOrder = new TextOrder(item.Text, dbContext);
                                if (textOrder.TryToParse())
                                {
                                    textOrder.Order.User_Id = item.UserId;
                                    textOrder.Order.Order_Status_Id = 1;

                                    string notEnoughText = "";

                                    foreach(Model.Receipt r in textOrder.Order.Receipts)
                                    {
                                        if (dbContext.Good_Dimensions.Find(r.Good_Dimension_Id).Available < r.Amount)
                                        {
                                            notEnoughText += "Not enough " + r.Good_Dimension + "\n" + "  Available: " + r.Good_Dimension.Available + "\n  In order: " + r.Amount;
                                        }
                                        else
                                        {
                                            dbContext.Good_Dimensions.Find(r.Good_Dimension_Id).Available -= r.Amount;
                                        }
                                    }
                                    if (notEnoughText.Length > 0)
                                    {
                                        await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, notEnoughText);
                                    }
                                    else
                                    {
                                        
                                        dbContext.Orders.Add(textOrder.Order);
                                        dbContext.SaveChanges();
                                        await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, "Order is created!\nFull price: "+textOrder.Order.Full_Price);
                                    }
                                }
                                else
                                {
                                    await instaApi.MessagingProcessor.SendDirectTextAsync(null, chat.ThreadId, "Wrong data or data format!");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
