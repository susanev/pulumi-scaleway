// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Scaleway.Outputs
{

    [OutputType]
    public sealed class GetLbFrontendsFrontendResult
    {
        /// <summary>
        /// The load-balancer backend ID this frontend is attached to.
        /// &gt; **Important:** LB backends' IDs are zoned, which means they are of the form `{zone}/{id}`, e.g. `fr-par-1/11111111-1111-1111-1111-111111111111`
        /// </summary>
        public readonly string BackendId;
        /// <summary>
        /// List of Certificate IDs that are used by the frontend.
        /// </summary>
        public readonly ImmutableArray<string> CertificateIds;
        /// <summary>
        /// The date at which the frontend was created (RFC 3339 format).
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// If HTTP/3 protocol is activated.
        /// </summary>
        public readonly bool EnableHttp3;
        /// <summary>
        /// The associated frontend ID.
        /// &gt; **Important:** LB frontends' IDs are zoned, which means they are of the form `{zone}/{id}`, e.g. `fr-par-1/11111111-1111-1111-1111-111111111111`
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// TCP port the frontend listen to.
        /// </summary>
        public readonly int InboundPort;
        /// <summary>
        /// The load-balancer ID this frontend is attached to. frontends with a LB ID like it are listed.
        /// </summary>
        public readonly string LbId;
        /// <summary>
        /// The frontend name used as filter. Frontends with a name like it are listed.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Maximum inactivity time on the client side.
        /// </summary>
        public readonly string TimeoutClient;
        /// <summary>
        /// The date at which the frontend was last updated (RFC 3339 format).
        /// </summary>
        public readonly string UpdateAt;

        [OutputConstructor]
        private GetLbFrontendsFrontendResult(
            string backendId,

            ImmutableArray<string> certificateIds,

            string createdAt,

            bool enableHttp3,

            string id,

            int inboundPort,

            string lbId,

            string name,

            string timeoutClient,

            string updateAt)
        {
            BackendId = backendId;
            CertificateIds = certificateIds;
            CreatedAt = createdAt;
            EnableHttp3 = enableHttp3;
            Id = id;
            InboundPort = inboundPort;
            LbId = lbId;
            Name = name;
            TimeoutClient = timeoutClient;
            UpdateAt = updateAt;
        }
    }
}
