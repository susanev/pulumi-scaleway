// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Scaleway
{
    [ScalewayResourceType("scaleway:index/loadbalancerCertificate:LoadbalancerCertificate")]
    public partial class LoadbalancerCertificate : Pulumi.CustomResource
    {
        /// <summary>
        /// Main domain of the certificate.
        /// </summary>
        [Output("commonName")]
        public Output<string> CommonName { get; private set; } = null!;

        /// <summary>
        /// Configuration block for custom certificate chain. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Output("customCertificate")]
        public Output<Outputs.LoadbalancerCertificateCustomCertificate?> CustomCertificate { get; private set; } = null!;

        /// <summary>
        /// The identifier (SHA-1) of the certificate
        /// </summary>
        [Output("fingerprint")]
        public Output<string> Fingerprint { get; private set; } = null!;

        /// <summary>
        /// The load-balancer ID this certificate is attached to.
        /// </summary>
        [Output("lbId")]
        public Output<string> LbId { get; private set; } = null!;

        /// <summary>
        /// Configuration block for Let's Encrypt configuration. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Output("letsencrypt")]
        public Output<Outputs.LoadbalancerCertificateLetsencrypt?> Letsencrypt { get; private set; } = null!;

        /// <summary>
        /// The name of the certificate backend.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The not valid after validity bound timestamp
        /// </summary>
        [Output("notValidAfter")]
        public Output<string> NotValidAfter { get; private set; } = null!;

        /// <summary>
        /// The not valid before validity bound timestamp
        /// </summary>
        [Output("notValidBefore")]
        public Output<string> NotValidBefore { get; private set; } = null!;

        /// <summary>
        /// Certificate status
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Array of alternative domain names.
        /// </summary>
        [Output("subjectAlternativeNames")]
        public Output<ImmutableArray<string>> SubjectAlternativeNames { get; private set; } = null!;


        /// <summary>
        /// Create a LoadbalancerCertificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadbalancerCertificate(string name, LoadbalancerCertificateArgs args, CustomResourceOptions? options = null)
            : base("scaleway:index/loadbalancerCertificate:LoadbalancerCertificate", name, args ?? new LoadbalancerCertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoadbalancerCertificate(string name, Input<string> id, LoadbalancerCertificateState? state = null, CustomResourceOptions? options = null)
            : base("scaleway:index/loadbalancerCertificate:LoadbalancerCertificate", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/jaxxstorm/pulumi-scaleway/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoadbalancerCertificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadbalancerCertificate Get(string name, Input<string> id, LoadbalancerCertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new LoadbalancerCertificate(name, id, state, options);
        }
    }

    public sealed class LoadbalancerCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block for custom certificate chain. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Input("customCertificate")]
        public Input<Inputs.LoadbalancerCertificateCustomCertificateArgs>? CustomCertificate { get; set; }

        /// <summary>
        /// The load-balancer ID this certificate is attached to.
        /// </summary>
        [Input("lbId", required: true)]
        public Input<string> LbId { get; set; } = null!;

        /// <summary>
        /// Configuration block for Let's Encrypt configuration. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Input("letsencrypt")]
        public Input<Inputs.LoadbalancerCertificateLetsencryptArgs>? Letsencrypt { get; set; }

        /// <summary>
        /// The name of the certificate backend.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LoadbalancerCertificateArgs()
        {
        }
    }

    public sealed class LoadbalancerCertificateState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Main domain of the certificate.
        /// </summary>
        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        /// <summary>
        /// Configuration block for custom certificate chain. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Input("customCertificate")]
        public Input<Inputs.LoadbalancerCertificateCustomCertificateGetArgs>? CustomCertificate { get; set; }

        /// <summary>
        /// The identifier (SHA-1) of the certificate
        /// </summary>
        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        /// <summary>
        /// The load-balancer ID this certificate is attached to.
        /// </summary>
        [Input("lbId")]
        public Input<string>? LbId { get; set; }

        /// <summary>
        /// Configuration block for Let's Encrypt configuration. Only one of `letsencrypt` and `custom_certificate` should be specified.
        /// </summary>
        [Input("letsencrypt")]
        public Input<Inputs.LoadbalancerCertificateLetsencryptGetArgs>? Letsencrypt { get; set; }

        /// <summary>
        /// The name of the certificate backend.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The not valid after validity bound timestamp
        /// </summary>
        [Input("notValidAfter")]
        public Input<string>? NotValidAfter { get; set; }

        /// <summary>
        /// The not valid before validity bound timestamp
        /// </summary>
        [Input("notValidBefore")]
        public Input<string>? NotValidBefore { get; set; }

        /// <summary>
        /// Certificate status
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;

        /// <summary>
        /// Array of alternative domain names.
        /// </summary>
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        public LoadbalancerCertificateState()
        {
        }
    }
}
