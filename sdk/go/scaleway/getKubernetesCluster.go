// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package scaleway

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets information about a Kubernetes Cluster.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-scaleway/sdk/go/scaleway"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := "11111111-1111-1111-1111-111111111111"
// 		_, err := scaleway.LookupKubernetesCluster(ctx, &GetKubernetesClusterArgs{
// 			ClusterId: &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupKubernetesCluster(ctx *pulumi.Context, args *LookupKubernetesClusterArgs, opts ...pulumi.InvokeOption) (*LookupKubernetesClusterResult, error) {
	var rv LookupKubernetesClusterResult
	err := ctx.Invoke("scaleway:index/getKubernetesCluster:getKubernetesCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKubernetesCluster.
type LookupKubernetesClusterArgs struct {
	// The cluster ID. Only one of `name` and `clusterId` should be specified.
	ClusterId *string `pulumi:"clusterId"`
	// The cluster name. Only one of `name` and `clusterId` should be specified.
	Name *string `pulumi:"name"`
	// `region`) The region in which the cluster exists.
	Region *string `pulumi:"region"`
}

// A collection of values returned by getKubernetesCluster.
type LookupKubernetesClusterResult struct {
	// The list of [admission plugins](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/) enabled on the cluster.
	AdmissionPlugins  []string `pulumi:"admissionPlugins"`
	ApiserverCertSans []string `pulumi:"apiserverCertSans"`
	// The URL of the Kubernetes API server.
	ApiserverUrl string `pulumi:"apiserverUrl"`
	// The auto upgrade configuration.
	AutoUpgrades []GetKubernetesClusterAutoUpgrade `pulumi:"autoUpgrades"`
	// The configuration options for the [Kubernetes cluster autoscaler](https://github.com/kubernetes/autoscaler/tree/master/cluster-autoscaler).
	AutoscalerConfigs []GetKubernetesClusterAutoscalerConfig `pulumi:"autoscalerConfigs"`
	ClusterId         *string                                `pulumi:"clusterId"`
	// The Container Network Interface (CNI) for the Kubernetes cluster.
	Cni string `pulumi:"cni"`
	// The creation date of the cluster.
	CreatedAt string `pulumi:"createdAt"`
	// A description for the Kubernetes cluster.
	Description string `pulumi:"description"`
	// The list of [feature gates](https://kubernetes.io/docs/reference/command-line-tools-reference/feature-gates/) enabled on the cluster.
	FeatureGates []string `pulumi:"featureGates"`
	// The provider-assigned unique ID for this managed resource.
	Id                   string                                    `pulumi:"id"`
	Kubeconfigs          []GetKubernetesClusterKubeconfig          `pulumi:"kubeconfigs"`
	Name                 *string                                   `pulumi:"name"`
	OpenIdConnectConfigs []GetKubernetesClusterOpenIdConnectConfig `pulumi:"openIdConnectConfigs"`
	// The ID of the organization the cluster is associated with.
	OrganizationId string `pulumi:"organizationId"`
	// The ID of the project the cluster is associated with.
	ProjectId string `pulumi:"projectId"`
	// The region in which the cluster is.
	Region *string `pulumi:"region"`
	// The status of the Kubernetes cluster.
	Status string `pulumi:"status"`
	// The tags associated with the Kubernetes cluster.
	Tags []string `pulumi:"tags"`
	Type string   `pulumi:"type"`
	// The last update date of the cluster.
	UpdatedAt string `pulumi:"updatedAt"`
	// True if a newer Kubernetes version is available.
	UpgradeAvailable bool `pulumi:"upgradeAvailable"`
	// The version of the Kubernetes cluster.
	Version string `pulumi:"version"`
	// The DNS wildcard that points to all ready nodes.
	WildcardDns string `pulumi:"wildcardDns"`
}

func LookupKubernetesClusterOutput(ctx *pulumi.Context, args LookupKubernetesClusterOutputArgs, opts ...pulumi.InvokeOption) LookupKubernetesClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupKubernetesClusterResult, error) {
			args := v.(LookupKubernetesClusterArgs)
			r, err := LookupKubernetesCluster(ctx, &args, opts...)
			return *r, err
		}).(LookupKubernetesClusterResultOutput)
}

// A collection of arguments for invoking getKubernetesCluster.
type LookupKubernetesClusterOutputArgs struct {
	// The cluster ID. Only one of `name` and `clusterId` should be specified.
	ClusterId pulumi.StringPtrInput `pulumi:"clusterId"`
	// The cluster name. Only one of `name` and `clusterId` should be specified.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// `region`) The region in which the cluster exists.
	Region pulumi.StringPtrInput `pulumi:"region"`
}

func (LookupKubernetesClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKubernetesClusterArgs)(nil)).Elem()
}

// A collection of values returned by getKubernetesCluster.
type LookupKubernetesClusterResultOutput struct{ *pulumi.OutputState }

func (LookupKubernetesClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKubernetesClusterResult)(nil)).Elem()
}

func (o LookupKubernetesClusterResultOutput) ToLookupKubernetesClusterResultOutput() LookupKubernetesClusterResultOutput {
	return o
}

func (o LookupKubernetesClusterResultOutput) ToLookupKubernetesClusterResultOutputWithContext(ctx context.Context) LookupKubernetesClusterResultOutput {
	return o
}

// The list of [admission plugins](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/) enabled on the cluster.
func (o LookupKubernetesClusterResultOutput) AdmissionPlugins() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []string { return v.AdmissionPlugins }).(pulumi.StringArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) ApiserverCertSans() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []string { return v.ApiserverCertSans }).(pulumi.StringArrayOutput)
}

// The URL of the Kubernetes API server.
func (o LookupKubernetesClusterResultOutput) ApiserverUrl() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ApiserverUrl }).(pulumi.StringOutput)
}

// The auto upgrade configuration.
func (o LookupKubernetesClusterResultOutput) AutoUpgrades() GetKubernetesClusterAutoUpgradeArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterAutoUpgrade { return v.AutoUpgrades }).(GetKubernetesClusterAutoUpgradeArrayOutput)
}

// The configuration options for the [Kubernetes cluster autoscaler](https://github.com/kubernetes/autoscaler/tree/master/cluster-autoscaler).
func (o LookupKubernetesClusterResultOutput) AutoscalerConfigs() GetKubernetesClusterAutoscalerConfigArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterAutoscalerConfig {
		return v.AutoscalerConfigs
	}).(GetKubernetesClusterAutoscalerConfigArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) ClusterId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) *string { return v.ClusterId }).(pulumi.StringPtrOutput)
}

// The Container Network Interface (CNI) for the Kubernetes cluster.
func (o LookupKubernetesClusterResultOutput) Cni() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Cni }).(pulumi.StringOutput)
}

// The creation date of the cluster.
func (o LookupKubernetesClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// A description for the Kubernetes cluster.
func (o LookupKubernetesClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

// The list of [feature gates](https://kubernetes.io/docs/reference/command-line-tools-reference/feature-gates/) enabled on the cluster.
func (o LookupKubernetesClusterResultOutput) FeatureGates() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []string { return v.FeatureGates }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupKubernetesClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) Kubeconfigs() GetKubernetesClusterKubeconfigArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterKubeconfig { return v.Kubeconfigs }).(GetKubernetesClusterKubeconfigArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupKubernetesClusterResultOutput) OpenIdConnectConfigs() GetKubernetesClusterOpenIdConnectConfigArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterOpenIdConnectConfig {
		return v.OpenIdConnectConfigs
	}).(GetKubernetesClusterOpenIdConnectConfigArrayOutput)
}

// The ID of the organization the cluster is associated with.
func (o LookupKubernetesClusterResultOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.OrganizationId }).(pulumi.StringOutput)
}

// The ID of the project the cluster is associated with.
func (o LookupKubernetesClusterResultOutput) ProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ProjectId }).(pulumi.StringOutput)
}

// The region in which the cluster is.
func (o LookupKubernetesClusterResultOutput) Region() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) *string { return v.Region }).(pulumi.StringPtrOutput)
}

// The status of the Kubernetes cluster.
func (o LookupKubernetesClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

// The tags associated with the Kubernetes cluster.
func (o LookupKubernetesClusterResultOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []string { return v.Tags }).(pulumi.StringArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Type }).(pulumi.StringOutput)
}

// The last update date of the cluster.
func (o LookupKubernetesClusterResultOutput) UpdatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.UpdatedAt }).(pulumi.StringOutput)
}

// True if a newer Kubernetes version is available.
func (o LookupKubernetesClusterResultOutput) UpgradeAvailable() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) bool { return v.UpgradeAvailable }).(pulumi.BoolOutput)
}

// The version of the Kubernetes cluster.
func (o LookupKubernetesClusterResultOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Version }).(pulumi.StringOutput)
}

// The DNS wildcard that points to all ready nodes.
func (o LookupKubernetesClusterResultOutput) WildcardDns() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.WildcardDns }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupKubernetesClusterResultOutput{})
}