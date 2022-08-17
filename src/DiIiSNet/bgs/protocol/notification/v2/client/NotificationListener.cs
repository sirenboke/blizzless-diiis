// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bgs.protocol.notification.v2.client {
  
  namespace Proto {
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public static partial class NotificationListener {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.notification.v2.client.NotificationReceivedNotification, global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.Builder> internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static NotificationListener() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            "CjtiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL25vdGlmaWNhdGlv" + 
            "bl9saXN0ZW5lci5wcm90bxIjYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52" + 
            "Mi5jbGllbnQaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90bxo4" + 
            "YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9ub3RpZmljYXRpb25f" + 
            "dHlwZXMucHJvdG8iewogTm90aWZpY2F0aW9uUmVjZWl2ZWROb3RpZmljYXRp" + 
            "b24SVwoNbm90aWZpY2F0aW9ucxgBIAMoCzIxLmJncy5wcm90b2NvbC5ub3Rp" + 
            "ZmljYXRpb24udjIuY2xpZW50Lk5vdGlmaWNhdGlvblINbm90aWZpY2F0aW9u" + 
            "czLuAQoUTm90aWZpY2F0aW9uTGlzdGVuZXISggEKFk9uTm90aWZpY2F0aW9u" + 
            "UmVjZWl2ZWQSRS5iZ3MucHJvdG9jb2wubm90aWZpY2F0aW9uLnYyLmNsaWVu" + 
            "dC5Ob3RpZmljYXRpb25SZWNlaXZlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90" + 
            "b2NvbC5OT19SRVNQT05TRSIGgvkrAggBGlGC+Ss7CjlibmV0LnByb3RvY29s" + 
            "Lm5vdGlmaWNhdGlvbi52Mi5jbGllbnQuTm90aWZpY2F0aW9uTGlzdGVuZXKC" + 
            "+SsCOAGK+SsCCAGK+SsCGAFCA4ABAA==");
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__Descriptor = Descriptor.MessageTypes[0];
          internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.notification.v2.client.NotificationReceivedNotification, global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.Builder>(internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__Descriptor,
                  new string[] { "Notifications", });
          pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
          RegisterAllExtensions(registry);
          global::bgs.protocol.RpcTypes.RegisterAllExtensions(registry);
          global::bgs.protocol.notification.v2.client.NotificationTypes.RegisterAllExtensions(registry);
          return registry;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            global::bgs.protocol.RpcTypes.Descriptor, 
            global::bgs.protocol.notification.v2.client.NotificationTypes.Descriptor, 
            }, assigner);
      }
      #endregion
      
    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class NotificationReceivedNotification : pb::GeneratedMessage<NotificationReceivedNotification, NotificationReceivedNotification.Builder> {
    private NotificationReceivedNotification() { }
    private static readonly NotificationReceivedNotification defaultInstance = new NotificationReceivedNotification().MakeReadOnly();
    private static readonly string[] _notificationReceivedNotificationFieldNames = new string[] { "notifications" };
    private static readonly uint[] _notificationReceivedNotificationFieldTags = new uint[] { 10 };
    public static NotificationReceivedNotification DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override NotificationReceivedNotification DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override NotificationReceivedNotification ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bgs.protocol.notification.v2.client.Proto.NotificationListener.internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<NotificationReceivedNotification, NotificationReceivedNotification.Builder> InternalFieldAccessors {
      get { return global::bgs.protocol.notification.v2.client.Proto.NotificationListener.internal__static_bgs_protocol_notification_v2_client_NotificationReceivedNotification__FieldAccessorTable; }
    }
    
    public const int NotificationsFieldNumber = 1;
    private pbc::PopsicleList<global::bgs.protocol.notification.v2.client.Notification> notifications_ = new pbc::PopsicleList<global::bgs.protocol.notification.v2.client.Notification>();
    public scg::IList<global::bgs.protocol.notification.v2.client.Notification> NotificationsList {
      get { return notifications_; }
    }
    public int NotificationsCount {
      get { return notifications_.Count; }
    }
    public global::bgs.protocol.notification.v2.client.Notification GetNotifications(int index) {
      return notifications_[index];
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _notificationReceivedNotificationFieldNames;
      if (notifications_.Count > 0) {
        output.WriteMessageArray(1, field_names[0], notifications_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        foreach (global::bgs.protocol.notification.v2.client.Notification element in NotificationsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static NotificationReceivedNotification ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static NotificationReceivedNotification ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static NotificationReceivedNotification ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private NotificationReceivedNotification MakeReadOnly() {
      notifications_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(NotificationReceivedNotification prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<NotificationReceivedNotification, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(NotificationReceivedNotification cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private NotificationReceivedNotification result;
      
      private NotificationReceivedNotification PrepareBuilder() {
        if (resultIsReadOnly) {
          NotificationReceivedNotification original = result;
          result = new NotificationReceivedNotification();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override NotificationReceivedNotification MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.Descriptor; }
      }
      
      public override NotificationReceivedNotification DefaultInstanceForType {
        get { return global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.DefaultInstance; }
      }
      
      public override NotificationReceivedNotification BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is NotificationReceivedNotification) {
          return MergeFrom((NotificationReceivedNotification) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(NotificationReceivedNotification other) {
        if (other == global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.DefaultInstance) return this;
        PrepareBuilder();
        if (other.notifications_.Count != 0) {
          result.notifications_.Add(other.notifications_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_notificationReceivedNotificationFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _notificationReceivedNotificationFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              input.ReadMessageArray(tag, field_name, result.notifications_, global::bgs.protocol.notification.v2.client.Notification.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public pbc::IPopsicleList<global::bgs.protocol.notification.v2.client.Notification> NotificationsList {
        get { return PrepareBuilder().notifications_; }
      }
      public int NotificationsCount {
        get { return result.NotificationsCount; }
      }
      public global::bgs.protocol.notification.v2.client.Notification GetNotifications(int index) {
        return result.GetNotifications(index);
      }
      public Builder SetNotifications(int index, global::bgs.protocol.notification.v2.client.Notification value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.notifications_[index] = value;
        return this;
      }
      public Builder SetNotifications(int index, global::bgs.protocol.notification.v2.client.Notification.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.notifications_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddNotifications(global::bgs.protocol.notification.v2.client.Notification value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.notifications_.Add(value);
        return this;
      }
      public Builder AddNotifications(global::bgs.protocol.notification.v2.client.Notification.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.notifications_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeNotifications(scg::IEnumerable<global::bgs.protocol.notification.v2.client.Notification> values) {
        PrepareBuilder();
        result.notifications_.Add(values);
        return this;
      }
      public Builder ClearNotifications() {
        PrepareBuilder();
        result.notifications_.Clear();
        return this;
      }
    }
    static NotificationReceivedNotification() {
      object.ReferenceEquals(global::bgs.protocol.notification.v2.client.Proto.NotificationListener.Descriptor, null);
    }
  }
  
  #endregion
  
  #region Services
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public abstract class NotificationListener : pb::IService {
    public abstract void OnNotificationReceived(
        pb::IRpcController controller,
        global::bgs.protocol.notification.v2.client.NotificationReceivedNotification request,
        global::System.Action<global::bgs.protocol.NO_RESPONSE> done);
    
    public static pbd::ServiceDescriptor Descriptor {
      get { return Proto.NotificationListener.Descriptor.Services[0]; }
    }
    public pbd::ServiceDescriptor DescriptorForType {
      get { return Descriptor; }
    }
    
    public void CallMethod(
        pbd::MethodDescriptor method,
        pb::IRpcController controller,
        pb::IMessage request,
        global::System.Action<pb::IMessage> done) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.CallMethod() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          this.OnNotificationReceived(controller, (global::bgs.protocol.notification.v2.client.NotificationReceivedNotification) request,
              pb::RpcUtil.SpecializeCallback<global::bgs.protocol.NO_RESPONSE>(
              done));
          return;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetRequestPrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetRequestPrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bgs.protocol.notification.v2.client.NotificationReceivedNotification.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetResponsePrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetResponsePrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bgs.protocol.NO_RESPONSE.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public static Stub CreateStub(pb::IRpcChannel channel) {
      return new Stub(channel);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public class Stub : global::bgs.protocol.notification.v2.client.NotificationListener {
      internal Stub(pb::IRpcChannel channel) {
        this.channel = channel;
      }
      
      private readonly pb::IRpcChannel channel;
      
      public pb::IRpcChannel Channel {
        get { return channel; }
      }
      
      public override void OnNotificationReceived(
          pb::IRpcController controller,
          global::bgs.protocol.notification.v2.client.NotificationReceivedNotification request,
          global::System.Action<global::bgs.protocol.NO_RESPONSE> done) {
        channel.CallMethod(Descriptor.Methods[0],
            controller, request, global::bgs.protocol.NO_RESPONSE.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bgs.protocol.NO_RESPONSE, global::bgs.protocol.NO_RESPONSE.Builder>(done, global::bgs.protocol.NO_RESPONSE.DefaultInstance));
      }
    }
  }
  #endregion
  
}

#endregion Designer generated code