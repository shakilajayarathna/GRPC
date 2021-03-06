// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class Customer
  {
    static readonly string __ServiceName = "customers.Customer";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcService.CustomerFindModel> __Marshaller_customers_CustomerFindModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.CustomerFindModel.Parser));
    static readonly grpc::Marshaller<global::GrpcService.CustomerDataModel> __Marshaller_customers_CustomerDataModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.CustomerDataModel.Parser));
    static readonly grpc::Marshaller<global::GrpcService.AllCustomerModel> __Marshaller_customers_AllCustomerModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.AllCustomerModel.Parser));

    static readonly grpc::Method<global::GrpcService.CustomerFindModel, global::GrpcService.CustomerDataModel> __Method_GetCustomerInfo = new grpc::Method<global::GrpcService.CustomerFindModel, global::GrpcService.CustomerDataModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerInfo",
        __Marshaller_customers_CustomerFindModel,
        __Marshaller_customers_CustomerDataModel);

    static readonly grpc::Method<global::GrpcService.AllCustomerModel, global::GrpcService.CustomerDataModel> __Method_GetAllCustomers = new grpc::Method<global::GrpcService.AllCustomerModel, global::GrpcService.CustomerDataModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllCustomers",
        __Marshaller_customers_AllCustomerModel,
        __Marshaller_customers_CustomerDataModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Customer</summary>
    [grpc::BindServiceMethod(typeof(Customer), "BindService")]
    public abstract partial class CustomerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.CustomerDataModel> GetCustomerInfo(global::GrpcService.CustomerFindModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllCustomers(global::GrpcService.AllCustomerModel request, grpc::IServerStreamWriter<global::GrpcService.CustomerDataModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerInfo, serviceImpl.GetCustomerInfo)
          .AddMethod(__Method_GetAllCustomers, serviceImpl.GetAllCustomers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CustomerFindModel, global::GrpcService.CustomerDataModel>(serviceImpl.GetCustomerInfo));
      serviceBinder.AddMethod(__Method_GetAllCustomers, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcService.AllCustomerModel, global::GrpcService.CustomerDataModel>(serviceImpl.GetAllCustomers));
    }

  }
}
#endregion
