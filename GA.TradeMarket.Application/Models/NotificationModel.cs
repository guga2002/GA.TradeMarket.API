﻿namespace GA.TradeMarket.Application.Models
{
    public class NotificationModel:AbstractModel
    {
        public long UserId { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }
    }
}