﻿namespace Mango.RewardAPI.Utility
{
    public sealed class SD
    {
        public static string OrderCreatedTopic {  get; set; }
        public static string OrderCreatedRewardsSubscription { get; set; }

        public static void Initializing(IConfiguration config)
        {
            OrderCreatedTopic = config["TopicAndQueueNames:OrderCreatedTopic"];
            OrderCreatedRewardsSubscription = config["TopicAndQueueNames:OrderCreatedRewardsSubscription"];
        }
    }
}
