// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: resto.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace api {
  public static partial class Restomgr
  {
    static readonly string __ServiceName = "resto.Restomgr";

    static readonly grpc::Marshaller<global::api.RestoRequest> __Marshaller_resto_RestoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::api.RestoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::api.RestoReply> __Marshaller_resto_RestoReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::api.RestoReply.Parser.ParseFrom);

    static readonly grpc::Method<global::api.RestoRequest, global::api.RestoReply> __Method_GetResto = new grpc::Method<global::api.RestoRequest, global::api.RestoReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetResto",
        __Marshaller_resto_RestoRequest,
        __Marshaller_resto_RestoReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::api.RestoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Restomgr</summary>
    [grpc::BindServiceMethod(typeof(Restomgr), "BindService")]
    public abstract partial class RestomgrBase
    {
      public virtual global::System.Threading.Tasks.Task<global::api.RestoReply> GetResto(global::api.RestoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RestomgrBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetResto, serviceImpl.GetResto).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RestomgrBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetResto, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::api.RestoRequest, global::api.RestoReply>(serviceImpl.GetResto));
    }

  }
}
#endregion
