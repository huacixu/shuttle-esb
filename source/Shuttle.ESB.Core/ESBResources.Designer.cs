﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shuttle.ESB.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ESBResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ESBResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shuttle.ESB.Core.ESBResources", typeof(ESBResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find assembly &apos;{0}&apos; during operation &apos;{1}&apos;..
        /// </summary>
        public static string AssemblyNotFound {
            get {
                return ResourceManager.GetString("AssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression algorithm &apos;{0}&apos; has not been registered..
        /// </summary>
        public static string CompressionAlgorithmException {
            get {
                return ResourceManager.GetString("CompressionAlgorithmException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [worker available ({0})] worker inbox = {1} / distributor control inbox = {2}.
        /// </summary>
        public static string DebugWorkerAvailable {
            get {
                return ResourceManager.GetString("DebugWorkerAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; has no default constructor..
        /// </summary>
        public static string DefaultConstructorRequired {
            get {
                return ResourceManager.GetString("DefaultConstructorRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler type &apos;{0}&apos; has no default constructor and will be ignored by the DefaultMessageHandlerFactory.  If you need to use this message handler you will need to make use of an IMessageHandlerFactory that can inject the dependency for you..
        /// </summary>
        public static string DefaultMessageHandlerFactoryNoDefaultConstructor {
            get {
                return ResourceManager.GetString("DefaultMessageHandlerFactoryNoDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one instance of the DeferredMessageProcessor should be created.  Check that the ProcessorThreadPool for the DeferredMessageProcessorFactory is not using more than 1 thread..
        /// </summary>
        public static string DeferredMessageProcessorInstanceException {
            get {
                return ResourceManager.GetString("DeferredMessageProcessorInstanceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A queue factory for scheme &apos;{0}&apos; already existed.  Removed queue factory type &apos;{1}&apos; to register queue factory type &apos;{2}&apos;..
        /// </summary>
        public static string DuplicateQueueFactoryReplaced {
            get {
                return ResourceManager.GetString("DuplicateQueueFactoryReplaced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The application configuration contains a &apos;durationToIgnoreOnFailure&apos; with invalid items &apos;{0}&apos;..
        /// </summary>
        public static string DurationToIgnoreOnFailureFormatError {
            get {
                return ResourceManager.GetString("DurationToIgnoreOnFailureFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption algorithm &apos;{0}&apos; has not been registered..
        /// </summary>
        public static string EncryptionAlgorithmException {
            get {
                return ResourceManager.GetString("EncryptionAlgorithmException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered a fatal exception accessing the idempotence service type &apos;{0}&apos;.  Without the idempotence service operational the integrity of the message processing cannot be guaranteed.  The pipeline has been aborted.  Exception: {1}.
        /// </summary>
        public static string FatalIdempotenceServiceException {
            get {
                return ResourceManager.GetString("FatalIdempotenceServiceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dd MMM yyyy HH:mm:ss.
        /// </summary>
        public static string FormatDateFull {
            get {
                return ResourceManager.GetString("FormatDateFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only scheme &apos;{0}&apos; is supported.  The given uri &apos;{1}&apos; is not supported..
        /// </summary>
        public static string InvalidSchemeException {
            get {
                return ResourceManager.GetString("InvalidSchemeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message handler type &apos;{0}&apos; raised exception &apos;{1}&apos;.  Message type &apos;{2}&apos; with id &apos;{3}&apos; has reached the maximum number of retries ({4}).  The message has been moved to error queue &apos;{5}&apos;.
        /// </summary>
        public static string MessageHandlerExceptionFailure {
            get {
                return ResourceManager.GetString("MessageHandlerExceptionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message handler type &apos;{0}&apos; raised exception &apos;{1}&apos;.  Handling of message type &apos;{2}&apos; with id &apos;{3}&apos; will be retried.  It is retry number: {4} / {5}.
        /// </summary>
        public static string MessageHandlerExceptionWillRetry {
            get {
                return ResourceManager.GetString("MessageHandlerExceptionWillRetry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message type &apos;{0}&apos; with id &apos;{1}&apos; invoking on handler &apos;{2}&apos;..
        /// </summary>
        public static string MessageHandlerInvoke {
            get {
                return ResourceManager.GetString("MessageHandlerInvoke", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No handler has been registered for message type &apos;{0}&apos;.  The message (id &apos;{1}&apos;) has been moved to error queue &apos;{2}&apos;..
        /// </summary>
        public static string MessageNotHandledFailure {
            get {
                return ResourceManager.GetString("MessageNotHandledFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No handler has been registered for message type &apos;{0}&apos;.  The message (id &apos;{1}&apos;) has been ignored..
        /// </summary>
        public static string MessageNotHandledIgnored {
            get {
                return ResourceManager.GetString("MessageNotHandledIgnored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message of type &apos;{0}&apos; has been routed to more than one endpoint: {1}.
        /// </summary>
        public static string MessageRoutedToMoreThanOneEndpoint {
            get {
                return ResourceManager.GetString("MessageRoutedToMoreThanOneEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No route could be found for message of type &apos;{0}&apos;..
        /// </summary>
        public static string MessageRouteNotFound {
            get {
                return ResourceManager.GetString("MessageRouteNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No IIdempotenceService implementation has been configured..
        /// </summary>
        public static string NoIdempotenceService {
            get {
                return ResourceManager.GetString("NoIdempotenceService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No IMessageHandlerFactory implementation has been configured..
        /// </summary>
        public static string NoMessageHandlerFactoryException {
            get {
                return ResourceManager.GetString("NoMessageHandlerFactoryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No IMessageRouteProvider (message routing) has been configured..
        /// </summary>
        public static string NoMessageRouteProviderException {
            get {
                return ResourceManager.GetString("NoMessageRouteProviderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No ISerializer implementation has been configured..
        /// </summary>
        public static string NoSerializerException {
            get {
                return ResourceManager.GetString("NoSerializerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No ISubscriptionManager implementation has been configured..
        /// </summary>
        public static string NoSubscriptionManager {
            get {
                return ResourceManager.GetString("NoSubscriptionManager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Queue &apos;{0}&apos; does not implement interface &apos;{1}&apos;..
        /// </summary>
        public static string NotImplementedOnQueue {
            get {
                return ResourceManager.GetString("NotImplementedOnQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No IUriResolver implementation has been configured.  Cannot resolve uri name &apos;{0}&apos;..
        /// </summary>
        public static string NoUriResolverException {
            get {
                return ResourceManager.GetString("NoUriResolverException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a section named &apos;{0}&apos; in configuration file &apos;{1}&apos;..
        /// </summary>
        public static string OpenSectionException {
            get {
                return ResourceManager.GetString("OpenSectionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not execute pipeline &apos;{0}&apos;.  Exception: {1}.
        /// </summary>
        public static string PipelineExecutionException {
            get {
                return ResourceManager.GetString("PipelineExecutionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipeline stage &apos;{0}&apos; has no event of type &apos;{1}&apos;..
        /// </summary>
        public static string PipelineStageEventNotRegistered {
            get {
                return ResourceManager.GetString("PipelineStageEventNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no pipeline stage with a name of &apos;{0}&apos;..
        /// </summary>
        public static string PipelineStageNotFound {
            get {
                return ResourceManager.GetString("PipelineStageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler type &apos;{0}&apos; does not have the requires ProcessMessage method that handles message type &apos;{1}&apos;..
        /// </summary>
        public static string ProcessMessageMethodMissingException {
            get {
                return ResourceManager.GetString("ProcessMessageMethodMissingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [publishing] : no subscription manager registered / event message type = &apos;{0}&apos;.
        /// </summary>
        public static string PublishWithoutSubscriptionManagerException {
            get {
                return ResourceManager.GetString("PublishWithoutSubscriptionManagerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No queue factory has been registered for scheme &apos;{0}&apos;..
        /// </summary>
        public static string QueueFactoryNotFoundException {
            get {
                return ResourceManager.GetString("QueueFactoryNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There has been an exception in the ReceiveMessagePipeline.  No message has been received.  Exception: {0}.
        /// </summary>
        public static string ReceivePipelineExceptionMessageNotReceived {
            get {
                return ResourceManager.GetString("ReceivePipelineExceptionMessageNotReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There has been an exception in the ReceiveMessagePipeline.  The message has been released.  Exception: {0}.
        /// </summary>
        public static string ReceivePipelineExceptionMessageReleased {
            get {
                return ResourceManager.GetString("ReceivePipelineExceptionMessageReleased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no current message.  Cannot reply..
        /// </summary>
        public static string ReplyWithoutCurrentMessage {
            get {
                return ResourceManager.GetString("ReplyWithoutCurrentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current message has no SenderIndexWorkQueueUri.  Cannot reply..
        /// </summary>
        public static string ReplyWithoutSenderInboxWorkQueueUri {
            get {
                return ResourceManager.GetString("ReplyWithoutSenderInboxWorkQueueUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have tried to requeue a message but no inbox has been configured..
        /// </summary>
        public static string RequeueWithNoInbox {
            get {
                return ResourceManager.GetString("RequeueWithNoInbox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required queue &apos;{0}&apos; has not been configured.  Please check your  application configuration or your code if you implemented it explicitly..
        /// </summary>
        public static string RequiredQueueMissing {
            get {
                return ResourceManager.GetString("RequiredQueueMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot send reply as the provided transport message received has no inbox work queue uri..
        /// </summary>
        public static string SendReplyException {
            get {
                return ResourceManager.GetString("SendReplyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot send a message to this endpoint (Local) since this endpoint has no inbox..
        /// </summary>
        public static string SendToSelfException {
            get {
                return ResourceManager.GetString("SendToSelfException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not registered with the serializer so it cannot be serialized.  Please use [SerialierInstance].AddKnownType to add the type before attempting to serialize or deserialize a TransportMessage containing this type in the object graph of the message property..
        /// </summary>
        public static string SerializerUnknownTypeExcption {
            get {
                return ResourceManager.GetString("SerializerUnknownTypeExcption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service bus instance has already been started..
        /// </summary>
        public static string ServiceBusInstanceAlreadyStarted {
            get {
                return ResourceManager.GetString("ServiceBusInstanceAlreadyStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue handler configuration requires thread count of at least 1.  The input queue can not be processed..
        /// </summary>
        public static string ThreadCountZeroException {
            get {
                return ResourceManager.GetString("ThreadCountZeroException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread pool &apos;{0}&apos; has {1} successfully..
        /// </summary>
        public static string ThreadPoolStatusChange {
            get {
                return ResourceManager.GetString("ThreadPoolStatusChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [acknowledged] : message type = &apos;{0}&apos; / message id = &apos;{1}&apos;.
        /// </summary>
        public static string TraceAcknowledge {
            get {
                return ResourceManager.GetString("TraceAcknowledge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [received correlation id] : &apos;{0}&apos;.
        /// </summary>
        public static string TraceCorrelationIdReceived {
            get {
                return ResourceManager.GetString("TraceCorrelationIdReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deferred transport message with id &apos;{0}&apos; has been returned to the inbox work queue..
        /// </summary>
        public static string TraceDeferredTransportMessageReturned {
            get {
                return ResourceManager.GetString("TraceDeferredTransportMessageReturned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forwarding transport message type &apos;{0}&apos; with id &apos;{1}&apos; to &apos;{2}&apos;..
        /// </summary>
        public static string TraceForwarding {
            get {
                return ResourceManager.GetString("TraceForwarding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message type &apos;{0}&apos; with id &apos;{1}&apos; has been deserialized..
        /// </summary>
        public static string TraceMessageDeserialized {
            get {
                return ResourceManager.GetString("TraceMessageDeserialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message type &apos;{0}&apos; with id &apos;{1}&apos; equeuing on queue &apos;{2}&apos;..
        /// </summary>
        public static string TraceMessageEnqueued {
            get {
                return ResourceManager.GetString("TraceMessageEnqueued", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [receive message state service] : transport message type &apos;{0}&apos; with id &apos;{1}&apos; has already been handled..
        /// </summary>
        public static string TraceMessageHandled {
            get {
                return ResourceManager.GetString("TraceMessageHandled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread active] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string TraceProcessorThreadActive {
            get {
                return ResourceManager.GetString("TraceProcessorThreadActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread starting] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string TraceProcessorThreadStarting {
            get {
                return ResourceManager.GetString("TraceProcessorThreadStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread stopped] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string TraceProcessorThreadStopped {
            get {
                return ResourceManager.GetString("TraceProcessorThreadStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread stopping] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string TraceProcessorThreadStopping {
            get {
                return ResourceManager.GetString("TraceProcessorThreadStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream dequeued from queue &apos;{0}&apos;..
        /// </summary>
        public static string TraceStreamDequeued {
            get {
                return ResourceManager.GetString("TraceStreamDequeued", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [transport message header (received)] : {0} = {1}.
        /// </summary>
        public static string TraceTransportHeaderReceived {
            get {
                return ResourceManager.GetString("TraceTransportHeaderReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transport message with id &apos;{0}&apos; will be deferred until &apos;{1}&apos;..
        /// </summary>
        public static string TraceTransportMessageDeferred {
            get {
                return ResourceManager.GetString("TraceTransportMessageDeferred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to &apos;{0}.{1}&apos; already contains an active TransactionScope..
        /// </summary>
        public static string TransactionAlreadyStartedException {
            get {
                return ResourceManager.GetString("TransactionAlreadyStartedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not deserialize the transport message from queue &apos;{0}&apos;.  Exception reported: {1}.
        /// </summary>
        public static string TransportMessageDeserializationException {
            get {
                return ResourceManager.GetString("TransportMessageDeserializationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransportMessage with message type &apos;{0}&apos; and id &apos;{1}&apos; has been deserialized..
        /// </summary>
        public static string TransportMessageDeserialized {
            get {
                return ResourceManager.GetString("TransportMessageDeserialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TripleDES section in the application configuration file may not have an empty value for the &apos;key&apos; attribute..
        /// </summary>
        public static string TripleDESKeyMissing {
            get {
                return ResourceManager.GetString("TripleDESKeyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to use TripleDES cryptography you need to add the &apos;tripleDES&apos; section to the application configuration file.  Remember to add the section handler..
        /// </summary>
        public static string TripleDESSectionMissing {
            get {
                return ResourceManager.GetString("TripleDESSectionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get type &apos;{0}&apos; for TypeListMessageRouteSpecification..
        /// </summary>
        public static string TypeListMessageRouteSpecificationUnknownType {
            get {
                return ResourceManager.GetString("TypeListMessageRouteSpecificationUnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled exception during event &apos;{0}&apos;: {1}.
        /// </summary>
        public static string UnhandledPipelineException {
            get {
                return ResourceManager.GetString("UnhandledPipelineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown message route specification &apos;{0}&apos;.  Cannot create the specification..
        /// </summary>
        public static string UnknownMessageRouteSpecification {
            get {
                return ResourceManager.GetString("UnknownMessageRouteSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected uri format &apos;{0}&apos; but received &apos;{1}&apos;..
        /// </summary>
        public static string UriFormatException {
            get {
                return ResourceManager.GetString("UriFormatException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IUriResolver type &apos;{0}&apos; could not resolve name &apos;{1}&apos;..
        /// </summary>
        public static string UriNameNotFoundException {
            get {
                return ResourceManager.GetString("UriNameNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entering pipeline stage &apos;{0}&apos;..
        /// </summary>
        public static string VerboseEnteringPipelineStage {
            get {
                return ResourceManager.GetString("VerboseEnteringPipelineStage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing pipeline &apos;{0}&apos;..
        /// </summary>
        public static string VerboseExecutingPipeline {
            get {
                return ResourceManager.GetString("VerboseExecutingPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First chance exception handled by pipeline: {0}.
        /// </summary>
        public static string VerboseFirstChanceExceptionHandledByPipeline {
            get {
                return ResourceManager.GetString("VerboseFirstChanceExceptionHandledByPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread executing] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string VerboseProcessorExecuting {
            get {
                return ResourceManager.GetString("VerboseProcessorExecuting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Raising pipeline event &apos;{0}&apos; in stage &apos;{1}&apos; for observer &apos;{2}&apos;..
        /// </summary>
        public static string VerboseRaisingPipelineEvent {
            get {
                return ResourceManager.GetString("VerboseRaisingPipelineEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) using ambient transaction..
        /// </summary>
        public static string VerboseTransactionScopeAmbient {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeAmbient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) using ambient transaction has completed..
        /// </summary>
        public static string VerboseTransactionScopeAmbientCompleted {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeAmbientCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) has completed..
        /// </summary>
        public static string VerboseTransactionScopeCompleted {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) created with isolation level &apos;{1}&apos; and timeout of &apos;{2}&apos;..
        /// </summary>
        public static string VerboseTransactionScopeCreated {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [publishing] : no subscribers / event message type = &apos;{0}&apos;.
        /// </summary>
        public static string WarningPublishWithoutSubscribers {
            get {
                return ResourceManager.GetString("WarningPublishWithoutSubscribers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No inbox has been configured.  A worker requires an inbox..
        /// </summary>
        public static string WorkerRequiresInbox {
            get {
                return ResourceManager.GetString("WorkerRequiresInbox", resourceCulture);
            }
        }
    }
}
