
using System;

namespace TECHIS.Messaging
{
    /// <summary>
    /// The Serialized Message Container class acts as a container for data that comes from, or is intended to be sent via a BrokeredMessage object.
    /// The class is not intended for serialization, but the Data property should contain the pre-serialized payload
    /// </summary>
    /// <typeparam name="T">Should be string or byte[]</typeparam>
    public interface ISerializedMessageContainer<T>
    {
        /// <summary>
        /// The message body
        /// </summary>
         T Data { get; }

         string Id { get; }
        /// <summary>
        /// Refers to the type of the MessageContainer
        /// </summary>
        int ContainerType { get; }
        /// <summary>
        /// A key that may be used to reterive the data
        /// </summary>
        string ReferenceKey { get; }
        /// <summary>
        /// Refers to the type of the contained message
        /// </summary>
        int DataType { get; }

        bool IsValid { get; }
        /// <summary>
        /// Refers to the class type of the serialized data (usually derived from Type.Name)
        /// </summary>
        string DataObjectType { get; }
        /// <summary>
        /// Refers to the version of the Data (represented by varying features sets
        /// </summary>
        string Version { get; }
        /// <summary>
        /// The Topic name under which the message is published.
        /// </summary>
        string TopicName { get; }
        /// <summary>
        /// The a unique identifier for the source of the message
        /// </summary>
        string SourceName { get; }

        DateTime CreateTime { get; }
    }
}