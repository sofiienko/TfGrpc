// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow_serving/apis/model_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Tensorflow.Serving {
  /// <summary>
  /// ModelService provides methods to query and update the state of the server,
  /// e.g. which models/versions are being served.
  /// </summary>
  public static partial class ModelService
  {
    static readonly string __ServiceName = "tensorflow.serving.ModelService";

    static readonly grpc::Marshaller<global::Tensorflow.Serving.GetModelStatusRequest> __Marshaller_tensorflow_serving_GetModelStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.GetModelStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.GetModelStatusResponse> __Marshaller_tensorflow_serving_GetModelStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.GetModelStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.ReloadConfigRequest> __Marshaller_tensorflow_serving_ReloadConfigRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.ReloadConfigRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.ReloadConfigResponse> __Marshaller_tensorflow_serving_ReloadConfigResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.ReloadConfigResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Tensorflow.Serving.GetModelStatusRequest, global::Tensorflow.Serving.GetModelStatusResponse> __Method_GetModelStatus = new grpc::Method<global::Tensorflow.Serving.GetModelStatusRequest, global::Tensorflow.Serving.GetModelStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetModelStatus",
        __Marshaller_tensorflow_serving_GetModelStatusRequest,
        __Marshaller_tensorflow_serving_GetModelStatusResponse);

    static readonly grpc::Method<global::Tensorflow.Serving.ReloadConfigRequest, global::Tensorflow.Serving.ReloadConfigResponse> __Method_HandleReloadConfigRequest = new grpc::Method<global::Tensorflow.Serving.ReloadConfigRequest, global::Tensorflow.Serving.ReloadConfigResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "HandleReloadConfigRequest",
        __Marshaller_tensorflow_serving_ReloadConfigRequest,
        __Marshaller_tensorflow_serving_ReloadConfigResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tensorflow.Serving.ModelServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ModelService</summary>
    public partial class ModelServiceClient : grpc::ClientBase<ModelServiceClient>
    {
      /// <summary>Creates a new client for ModelService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ModelServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ModelService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ModelServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ModelServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ModelServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Gets status of model. If the ModelSpec in the request does not specify
      /// version, information about all versions of the model will be returned. If
      /// the ModelSpec in the request does specify a version, the status of only
      /// that version will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.GetModelStatusResponse GetModelStatus(global::Tensorflow.Serving.GetModelStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetModelStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets status of model. If the ModelSpec in the request does not specify
      /// version, information about all versions of the model will be returned. If
      /// the ModelSpec in the request does specify a version, the status of only
      /// that version will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.GetModelStatusResponse GetModelStatus(global::Tensorflow.Serving.GetModelStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetModelStatus, null, options, request);
      }
      /// <summary>
      /// Gets status of model. If the ModelSpec in the request does not specify
      /// version, information about all versions of the model will be returned. If
      /// the ModelSpec in the request does specify a version, the status of only
      /// that version will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.GetModelStatusResponse> GetModelStatusAsync(global::Tensorflow.Serving.GetModelStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetModelStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets status of model. If the ModelSpec in the request does not specify
      /// version, information about all versions of the model will be returned. If
      /// the ModelSpec in the request does specify a version, the status of only
      /// that version will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.GetModelStatusResponse> GetModelStatusAsync(global::Tensorflow.Serving.GetModelStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetModelStatus, null, options, request);
      }
      /// <summary>
      /// Reloads the set of served models. The new config supersedes the old one,
      /// so if a model is omitted from the new config it will be unloaded and no
      /// longer served.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.ReloadConfigResponse HandleReloadConfigRequest(global::Tensorflow.Serving.ReloadConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HandleReloadConfigRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reloads the set of served models. The new config supersedes the old one,
      /// so if a model is omitted from the new config it will be unloaded and no
      /// longer served.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.ReloadConfigResponse HandleReloadConfigRequest(global::Tensorflow.Serving.ReloadConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_HandleReloadConfigRequest, null, options, request);
      }
      /// <summary>
      /// Reloads the set of served models. The new config supersedes the old one,
      /// so if a model is omitted from the new config it will be unloaded and no
      /// longer served.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.ReloadConfigResponse> HandleReloadConfigRequestAsync(global::Tensorflow.Serving.ReloadConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HandleReloadConfigRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reloads the set of served models. The new config supersedes the old one,
      /// so if a model is omitted from the new config it will be unloaded and no
      /// longer served.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.ReloadConfigResponse> HandleReloadConfigRequestAsync(global::Tensorflow.Serving.ReloadConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_HandleReloadConfigRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ModelServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ModelServiceClient(configuration);
      }
    }

  }
}
#endregion
