using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    class DefaultPublicationResourceManager : IPublicationResourceManager
    {
        public void CreateSubscription(CreateSubscriptionRequest request)
        {

        }

        public Task CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            return Task.CompletedTask;
        }

        public void CreateTopic(TopicRequest request)
        {

        }

        public Task CreateTopicAsync(TopicRequest request)
        {
            return Task.CompletedTask;
        }

        public void DeleteSubscription(DeleteSubscriptionRequest request)
        {
        }

        public Task DeleteSubscriptionAsync(DeleteSubscriptionRequest request)
        {
            return Task.CompletedTask;
        }

        public void DeleteTopic(TopicRequest request)
        {

        }

        public Task DeleteTopicAsync(TopicRequest request)
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }

        public IList<string> ListSubscriptions(ListSubscriptionRequest request)
        {
            return new List<string>(0);
        }

        public Task<IList<string>> ListSubscriptionsAsync(ListSubscriptionRequest request)
        {
            return Task.FromResult<IList<string>>(new List<string>(0));
        }

        public IList<string> ListTopics(ListTopicRequest request)
        {
            return new List<string>(0);
        }

        public Task<IList<string>> ListTopicsAsync(ListTopicRequest request)
        {
            return Task.FromResult<IList<string>>(new List<string>(0));
        }
    }
}
