// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CodingMilitia.ActorPerEntityProtoActorSample.Messages {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SCG1lc3NhZ2VzIhEKD0RvQWN0aW9uUmVxdWVzdCIY",
            "ChZEb0Fub3RoZXJBY3Rpb25SZXF1ZXN0Ih0KG1F1ZXJ5RXhlY3V0ZWRBY3Rp",
            "b25zUmVxdWVzdCJhChxRdWVyeUV4ZWN1dGVkQWN0aW9uc1Jlc3BvbnNlEhMK",
            "C0FjdGlvbkNvdW50GAEgASgFEhoKEkFub3RoZXJBY3Rpb25Db3VudBgCIAEo",
            "BRIQCghTZXJ2ZXJJZBgDIAEoCUI4qgI1Q29kaW5nTWlsaXRpYS5BY3RvclBl",
            "ckVudGl0eVByb3RvQWN0b3JTYW1wbGUuTWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.DoActionRequest), global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.DoActionRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.DoAnotherActionRequest), global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.DoAnotherActionRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.QueryExecutedActionsRequest), global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.QueryExecutedActionsRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.QueryExecutedActionsResponse), global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.QueryExecutedActionsResponse.Parser, new[]{ "ActionCount", "AnotherActionCount", "ServerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DoActionRequest : pb::IMessage<DoActionRequest> {
    private static readonly pb::MessageParser<DoActionRequest> _parser = new pb::MessageParser<DoActionRequest>(() => new DoActionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DoActionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoActionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoActionRequest(DoActionRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoActionRequest Clone() {
      return new DoActionRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DoActionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DoActionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DoActionRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class DoAnotherActionRequest : pb::IMessage<DoAnotherActionRequest> {
    private static readonly pb::MessageParser<DoAnotherActionRequest> _parser = new pb::MessageParser<DoAnotherActionRequest>(() => new DoAnotherActionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DoAnotherActionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoAnotherActionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoAnotherActionRequest(DoAnotherActionRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoAnotherActionRequest Clone() {
      return new DoAnotherActionRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DoAnotherActionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DoAnotherActionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DoAnotherActionRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class QueryExecutedActionsRequest : pb::IMessage<QueryExecutedActionsRequest> {
    private static readonly pb::MessageParser<QueryExecutedActionsRequest> _parser = new pb::MessageParser<QueryExecutedActionsRequest>(() => new QueryExecutedActionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryExecutedActionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsRequest(QueryExecutedActionsRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsRequest Clone() {
      return new QueryExecutedActionsRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryExecutedActionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryExecutedActionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryExecutedActionsRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class QueryExecutedActionsResponse : pb::IMessage<QueryExecutedActionsResponse> {
    private static readonly pb::MessageParser<QueryExecutedActionsResponse> _parser = new pb::MessageParser<QueryExecutedActionsResponse>(() => new QueryExecutedActionsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryExecutedActionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsResponse(QueryExecutedActionsResponse other) : this() {
      actionCount_ = other.actionCount_;
      anotherActionCount_ = other.anotherActionCount_;
      serverId_ = other.serverId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryExecutedActionsResponse Clone() {
      return new QueryExecutedActionsResponse(this);
    }

    /// <summary>Field number for the "ActionCount" field.</summary>
    public const int ActionCountFieldNumber = 1;
    private int actionCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ActionCount {
      get { return actionCount_; }
      set {
        actionCount_ = value;
      }
    }

    /// <summary>Field number for the "AnotherActionCount" field.</summary>
    public const int AnotherActionCountFieldNumber = 2;
    private int anotherActionCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AnotherActionCount {
      get { return anotherActionCount_; }
      set {
        anotherActionCount_ = value;
      }
    }

    /// <summary>Field number for the "ServerId" field.</summary>
    public const int ServerIdFieldNumber = 3;
    private string serverId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServerId {
      get { return serverId_; }
      set {
        serverId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryExecutedActionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryExecutedActionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActionCount != other.ActionCount) return false;
      if (AnotherActionCount != other.AnotherActionCount) return false;
      if (ServerId != other.ServerId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ActionCount != 0) hash ^= ActionCount.GetHashCode();
      if (AnotherActionCount != 0) hash ^= AnotherActionCount.GetHashCode();
      if (ServerId.Length != 0) hash ^= ServerId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ActionCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ActionCount);
      }
      if (AnotherActionCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AnotherActionCount);
      }
      if (ServerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ServerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ActionCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ActionCount);
      }
      if (AnotherActionCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnotherActionCount);
      }
      if (ServerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryExecutedActionsResponse other) {
      if (other == null) {
        return;
      }
      if (other.ActionCount != 0) {
        ActionCount = other.ActionCount;
      }
      if (other.AnotherActionCount != 0) {
        AnotherActionCount = other.AnotherActionCount;
      }
      if (other.ServerId.Length != 0) {
        ServerId = other.ServerId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ActionCount = input.ReadInt32();
            break;
          }
          case 16: {
            AnotherActionCount = input.ReadInt32();
            break;
          }
          case 26: {
            ServerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code