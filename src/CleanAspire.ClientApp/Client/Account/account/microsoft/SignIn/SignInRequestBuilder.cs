// <auto-generated/>
#pragma warning disable CS0618
using CleanAspire.Api.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace CleanAspire.Api.Client.Account.Microsoft.SignIn
{
    /// <summary>
    /// Builds and executes requests for operations under \account\microsoft\signIn
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SignInRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignInRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/account/microsoft/signIn?code={code}&state={state}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignInRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/account/microsoft/signIn?code={code}&state={state}", rawUrl)
        {
        }
        /// <summary>
        /// Handles external login using Microsoft Azure OAuth 2.0. Exchanges an authorization code for tokens, validates the user&apos;s identity, and signs the user in.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::CleanAspire.Api.Client.Models.ProblemDetails">When receiving a 400 status code</exception>
        /// <exception cref="global::CleanAspire.Api.Client.Models.HttpValidationProblemDetails">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(Action<RequestConfiguration<global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder.SignInRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(Action<RequestConfiguration<global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder.SignInRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::CleanAspire.Api.Client.Models.ProblemDetails.CreateFromDiscriminatorValue },
                { "422", global::CleanAspire.Api.Client.Models.HttpValidationProblemDetails.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Handles external login using Microsoft Azure OAuth 2.0. Exchanges an authorization code for tokens, validates the user&apos;s identity, and signs the user in.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder.SignInRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder.SignInRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder WithUrl(string rawUrl)
        {
            return new global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Handles external login using Microsoft Azure OAuth 2.0. Exchanges an authorization code for tokens, validates the user&apos;s identity, and signs the user in.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SignInRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("code")]
            public string? Code { get; set; }
#nullable restore
#else
            [QueryParameter("code")]
            public string Code { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SignInRequestBuilderPostRequestConfiguration : RequestConfiguration<global::CleanAspire.Api.Client.Account.Microsoft.SignIn.SignInRequestBuilder.SignInRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
