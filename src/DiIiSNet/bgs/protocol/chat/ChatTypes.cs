// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bgs.protocol.chat {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public static partial class ChatTypes {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      registry.Add(global::bgs.protocol.chat.ChannelState.Chat);
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bgs_protocol_chat_ChannelState__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.chat.ChannelState, global::bgs.protocol.chat.ChannelState.Builder> internal__static_bgs_protocol_chat_ChannelState__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static ChatTypes() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChVibmV0L2NoYXRfdHlwZXMucHJvdG8SEmJuZXQucHJvdG9jb2wuY2hhdBoY" + 
          "Ym5ldC9jaGFubmVsX3R5cGVzLnByb3RvIrIBCgxDaGFubmVsU3RhdGUSEAoI" + 
          "aWRlbnRpdHkYASABKAkSDgoGbG9jYWxlGAMgASgHEhUKBnB1YmxpYxgEIAEo" + 
          "CDoFZmFsc2USFAoMYnVja2V0X2luZGV4GAUgASgNMlMKBGNoYXQSIy5ibmV0" + 
          "LnByb3RvY29sLmNoYW5uZWwuQ2hhbm5lbFN0YXRlGGQgASgLMiAuYm5ldC5w" + 
          "cm90b2NvbC5jaGF0LkNoYW5uZWxTdGF0ZQ==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bgs_protocol_chat_ChannelState__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bgs_protocol_chat_ChannelState__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.chat.ChannelState, global::bgs.protocol.chat.ChannelState.Builder>(internal__static_bgs_protocol_chat_ChannelState__Descriptor,
                new string[] { "Identity", "Locale", "Public", "BucketIndex", });
        global::bgs.protocol.chat.ChannelState.Chat = pb::GeneratedSingleExtension<global::bgs.protocol.chat.ChannelState>.CreateInstance(global::bgs.protocol.chat.ChannelState.Descriptor.Extensions[0]);
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bgs.protocol.channel.v1.ChannelTypes.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class ChannelState : pb::GeneratedMessage<ChannelState, ChannelState.Builder> {
    private ChannelState() { }
    private static readonly ChannelState defaultInstance = new ChannelState().MakeReadOnly();
    private static readonly string[] _channelStateFieldNames = new string[] { "bucket_index", "identity", "locale", "public" };
    private static readonly uint[] _channelStateFieldTags = new uint[] { 40, 10, 29, 32 };
    public static ChannelState DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ChannelState DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override ChannelState ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bgs.protocol.chat.ChatTypes.internal__static_bgs_protocol_chat_ChannelState__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ChannelState, ChannelState.Builder> InternalFieldAccessors {
      get { return global::bgs.protocol.chat.ChatTypes.internal__static_bgs_protocol_chat_ChannelState__FieldAccessorTable; }
    }
    
    public const int ChatFieldNumber = 100;
    public static pb::GeneratedExtensionBase<global::bgs.protocol.chat.ChannelState> Chat;
    public const int IdentityFieldNumber = 1;
    private bool hasIdentity;
    private string identity_ = "";
    public bool HasIdentity {
      get { return hasIdentity; }
    }
    public string Identity {
      get { return identity_; }
    }
    
    public const int LocaleFieldNumber = 3;
    private bool hasLocale;
    private uint locale_;
    public bool HasLocale {
      get { return hasLocale; }
    }
    public uint Locale {
      get { return locale_; }
    }
    
    public const int PublicFieldNumber = 4;
    private bool hasPublic;
    private bool public_;
    public bool HasPublic {
      get { return hasPublic; }
    }
    public bool Public {
      get { return public_; }
    }
    
    public const int BucketIndexFieldNumber = 5;
    private bool hasBucketIndex;
    private uint bucketIndex_;
    public bool HasBucketIndex {
      get { return hasBucketIndex; }
    }
    public uint BucketIndex {
      get { return bucketIndex_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _channelStateFieldNames;
      if (hasIdentity) {
        output.WriteString(1, field_names[1], Identity);
      }
      if (hasLocale) {
        output.WriteFixed32(3, field_names[2], Locale);
      }
      if (hasPublic) {
        output.WriteBool(4, field_names[3], Public);
      }
      if (hasBucketIndex) {
        output.WriteUInt32(5, field_names[0], BucketIndex);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasIdentity) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Identity);
        }
        if (hasLocale) {
          size += pb::CodedOutputStream.ComputeFixed32Size(3, Locale);
        }
        if (hasPublic) {
          size += pb::CodedOutputStream.ComputeBoolSize(4, Public);
        }
        if (hasBucketIndex) {
          size += pb::CodedOutputStream.ComputeUInt32Size(5, BucketIndex);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ChannelState ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ChannelState ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ChannelState ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ChannelState ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ChannelState ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ChannelState ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ChannelState ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ChannelState ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ChannelState ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ChannelState ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ChannelState MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ChannelState prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<ChannelState, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ChannelState cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private ChannelState result;
      
      private ChannelState PrepareBuilder() {
        if (resultIsReadOnly) {
          ChannelState original = result;
          result = new ChannelState();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override ChannelState MessageBeingBuilt {
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
        get { return global::bgs.protocol.chat.ChannelState.Descriptor; }
      }
      
      public override ChannelState DefaultInstanceForType {
        get { return global::bgs.protocol.chat.ChannelState.DefaultInstance; }
      }
      
      public override ChannelState BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ChannelState) {
          return MergeFrom((ChannelState) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ChannelState other) {
        if (other == global::bgs.protocol.chat.ChannelState.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasIdentity) {
          Identity = other.Identity;
        }
        if (other.HasLocale) {
          Locale = other.Locale;
        }
        if (other.HasPublic) {
          Public = other.Public;
        }
        if (other.HasBucketIndex) {
          BucketIndex = other.BucketIndex;
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
            int field_ordinal = global::System.Array.BinarySearch(_channelStateFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _channelStateFieldTags[field_ordinal];
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
              result.hasIdentity = input.ReadString(ref result.identity_);
              break;
            }
            case 29: {
              result.hasLocale = input.ReadFixed32(ref result.locale_);
              break;
            }
            case 32: {
              result.hasPublic = input.ReadBool(ref result.public_);
              break;
            }
            case 40: {
              result.hasBucketIndex = input.ReadUInt32(ref result.bucketIndex_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasIdentity {
        get { return result.hasIdentity; }
      }
      public string Identity {
        get { return result.Identity; }
        set { SetIdentity(value); }
      }
      public Builder SetIdentity(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasIdentity = true;
        result.identity_ = value;
        return this;
      }
      public Builder ClearIdentity() {
        PrepareBuilder();
        result.hasIdentity = false;
        result.identity_ = "";
        return this;
      }
      
      public bool HasLocale {
        get { return result.hasLocale; }
      }
      public uint Locale {
        get { return result.Locale; }
        set { SetLocale(value); }
      }
      public Builder SetLocale(uint value) {
        PrepareBuilder();
        result.hasLocale = true;
        result.locale_ = value;
        return this;
      }
      public Builder ClearLocale() {
        PrepareBuilder();
        result.hasLocale = false;
        result.locale_ = 0;
        return this;
      }
      
      public bool HasPublic {
        get { return result.hasPublic; }
      }
      public bool Public {
        get { return result.Public; }
        set { SetPublic(value); }
      }
      public Builder SetPublic(bool value) {
        PrepareBuilder();
        result.hasPublic = true;
        result.public_ = value;
        return this;
      }
      public Builder ClearPublic() {
        PrepareBuilder();
        result.hasPublic = false;
        result.public_ = false;
        return this;
      }
      
      public bool HasBucketIndex {
        get { return result.hasBucketIndex; }
      }
      public uint BucketIndex {
        get { return result.BucketIndex; }
        set { SetBucketIndex(value); }
      }
      public Builder SetBucketIndex(uint value) {
        PrepareBuilder();
        result.hasBucketIndex = true;
        result.bucketIndex_ = value;
        return this;
      }
      public Builder ClearBucketIndex() {
        PrepareBuilder();
        result.hasBucketIndex = false;
        result.bucketIndex_ = 0;
        return this;
      }
    }
    static ChannelState() {
      object.ReferenceEquals(global::bgs.protocol.chat.ChatTypes.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code