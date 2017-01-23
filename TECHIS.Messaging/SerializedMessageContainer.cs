using System;
using System.Collections.Generic;


namespace TECHIS.Messaging
{
    /// <summary>
    /// The Serialized Message Container class acts as a container for data that comes from, or is intended to be sent via a BrokeredMessage object.
    /// The class is not intended for serialization, but the Data property should contain the pre-serialized payload
    /// </summary>
    /// <typeparam name="T">Should be string or byte[]</typeparam>
    public class DefaultSerializedMessageContainer<T>: ISerializedMessageContainer<T>
    {
        #region Fields 
        private readonly T _Data;

        private readonly string _Id;
        /// <summary>
        /// Refers to the type of the MessageInfo
        /// </summary>
        private readonly int _ContainerType;

        private readonly string _ReferenceKey;
        /// <summary>
        /// Refers to the type of the contained message
        /// </summary>
        private readonly int _DataType;

        private readonly bool _IsValid;
        /// <summary>
        /// Refers to the class type of the serialized data (usually derived from Type.Name)
        /// </summary>
        private readonly string _DataObjectType;
        /// <summary>
        /// Refers to the version of the Data (represented by varying features sets
        /// </summary>
        private readonly string _Version;
        /// <summary>
        /// The Topic name under which the message is published.
        /// </summary>
        private readonly string _TopicName;

        private readonly DateTime _CreateTime;

        private readonly string _SourceName;
        #endregion

        #region Properties 
        public bool IsValid
        {
            get
            {
                return _IsValid;
            }
        }

        public T Data
        {
            get
            {
                return _Data;
            }
        }

        public string Id
        {
            get
            {
                return _Id;
            }
        }

        public int ContainerType
        {
            get
            {
                return _ContainerType;
            }
        }

        public string ReferenceKey
        {
            get
            {
                return _ReferenceKey;
            }
        }

        public int DataType
        {
            get
            {
                return _DataType;
            }
        }

        public string DataObjectType
        {
            get
            {
                return _DataObjectType;
            }
        }

        public string Version
        {
            get
            {
                return _Version;
            }
        }

        public string TopicName
        {
            get
            {
                return _TopicName;
            }
        }

        public DateTime CreateTime
        {
            get
            {
                return _CreateTime;
            }
        }

        public string SourceName
        {
            get
            {
                return _SourceName;
            }
        }
        #endregion

        #region Constructors 
        public DefaultSerializedMessageContainer(
            T data = default(T), string id = default(string), int type = default(int), 
            string referenceKey = default(string), int messageType = default(int), long createTimeAsTicks = default(long), 
            string dataObjectType = default(string), string version = default(string), string topicName = default(string), 
            string sourceName = default(string) )
        {
            _Data           = data;
            _Id             = string.IsNullOrEmpty(id) ? GenKey() : id;
            _ContainerType  = type;
            _ReferenceKey   = referenceKey;
            _DataType       = messageType;
            _CreateTime     = createTimeAsTicks < 1 ? DateTime.UtcNow : new DateTime(createTimeAsTicks);
            _IsValid        = true;
            _DataObjectType = dataObjectType;
            _Version        = version;
            _TopicName      = topicName;
            _SourceName     = sourceName;
        }
        #endregion

        #region Private Methods 

        private static string GenKey()
        {
            string val = Guid.NewGuid().ToString().Trim('{', '}');
            return val;
        }
        #endregion

    }
}
