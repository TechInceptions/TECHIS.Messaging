using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public interface IPublicationResourceManager
    {
        #region Public Methods 

        Task CreateSubscriptionAsync(CreateSubscriptionRequest request);
        void CreateSubscription(CreateSubscriptionRequest request);

        void DeleteSubscription(DeleteSubscriptionRequest request);

        Task DeleteSubscriptionAsync(DeleteSubscriptionRequest request);

        void CreateTopic(TopicRequest request);

        Task CreateTopicAsync(TopicRequest request);
        void DeleteTopic(TopicRequest request);

        Task DeleteTopicAsync(TopicRequest request);

        Task<IList<string>> ListSubscriptionsAsync(ListSubscriptionRequest request);

        IList<string> ListSubscriptions(ListSubscriptionRequest request);
        Task<IList<string>> ListTopicsAsync(ListTopicRequest request);

        IList<string> ListTopics(ListTopicRequest request);
        #endregion
    }
}
