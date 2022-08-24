// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scaleway

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type DatabasePrivilege struct {
	pulumi.CustomResourceState

	// Database name
	DatabaseName pulumi.StringOutput `pulumi:"databaseName"`
	// Instance on which the database is created
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Privilege
	Permission pulumi.StringOutput `pulumi:"permission"`
	// User name
	UserName pulumi.StringOutput `pulumi:"userName"`
}

// NewDatabasePrivilege registers a new resource with the given unique name, arguments, and options.
func NewDatabasePrivilege(ctx *pulumi.Context,
	name string, args *DatabasePrivilegeArgs, opts ...pulumi.ResourceOption) (*DatabasePrivilege, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatabaseName == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseName'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.Permission == nil {
		return nil, errors.New("invalid value for required argument 'Permission'")
	}
	if args.UserName == nil {
		return nil, errors.New("invalid value for required argument 'UserName'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource DatabasePrivilege
	err := ctx.RegisterResource("scaleway:index/databasePrivilege:DatabasePrivilege", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabasePrivilege gets an existing DatabasePrivilege resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabasePrivilege(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabasePrivilegeState, opts ...pulumi.ResourceOption) (*DatabasePrivilege, error) {
	var resource DatabasePrivilege
	err := ctx.ReadResource("scaleway:index/databasePrivilege:DatabasePrivilege", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatabasePrivilege resources.
type databasePrivilegeState struct {
	// Database name
	DatabaseName *string `pulumi:"databaseName"`
	// Instance on which the database is created
	InstanceId *string `pulumi:"instanceId"`
	// Privilege
	Permission *string `pulumi:"permission"`
	// User name
	UserName *string `pulumi:"userName"`
}

type DatabasePrivilegeState struct {
	// Database name
	DatabaseName pulumi.StringPtrInput
	// Instance on which the database is created
	InstanceId pulumi.StringPtrInput
	// Privilege
	Permission pulumi.StringPtrInput
	// User name
	UserName pulumi.StringPtrInput
}

func (DatabasePrivilegeState) ElementType() reflect.Type {
	return reflect.TypeOf((*databasePrivilegeState)(nil)).Elem()
}

type databasePrivilegeArgs struct {
	// Database name
	DatabaseName string `pulumi:"databaseName"`
	// Instance on which the database is created
	InstanceId string `pulumi:"instanceId"`
	// Privilege
	Permission string `pulumi:"permission"`
	// User name
	UserName string `pulumi:"userName"`
}

// The set of arguments for constructing a DatabasePrivilege resource.
type DatabasePrivilegeArgs struct {
	// Database name
	DatabaseName pulumi.StringInput
	// Instance on which the database is created
	InstanceId pulumi.StringInput
	// Privilege
	Permission pulumi.StringInput
	// User name
	UserName pulumi.StringInput
}

func (DatabasePrivilegeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databasePrivilegeArgs)(nil)).Elem()
}

type DatabasePrivilegeInput interface {
	pulumi.Input

	ToDatabasePrivilegeOutput() DatabasePrivilegeOutput
	ToDatabasePrivilegeOutputWithContext(ctx context.Context) DatabasePrivilegeOutput
}

func (*DatabasePrivilege) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabasePrivilege)(nil)).Elem()
}

func (i *DatabasePrivilege) ToDatabasePrivilegeOutput() DatabasePrivilegeOutput {
	return i.ToDatabasePrivilegeOutputWithContext(context.Background())
}

func (i *DatabasePrivilege) ToDatabasePrivilegeOutputWithContext(ctx context.Context) DatabasePrivilegeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabasePrivilegeOutput)
}

// DatabasePrivilegeArrayInput is an input type that accepts DatabasePrivilegeArray and DatabasePrivilegeArrayOutput values.
// You can construct a concrete instance of `DatabasePrivilegeArrayInput` via:
//
//	DatabasePrivilegeArray{ DatabasePrivilegeArgs{...} }
type DatabasePrivilegeArrayInput interface {
	pulumi.Input

	ToDatabasePrivilegeArrayOutput() DatabasePrivilegeArrayOutput
	ToDatabasePrivilegeArrayOutputWithContext(context.Context) DatabasePrivilegeArrayOutput
}

type DatabasePrivilegeArray []DatabasePrivilegeInput

func (DatabasePrivilegeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DatabasePrivilege)(nil)).Elem()
}

func (i DatabasePrivilegeArray) ToDatabasePrivilegeArrayOutput() DatabasePrivilegeArrayOutput {
	return i.ToDatabasePrivilegeArrayOutputWithContext(context.Background())
}

func (i DatabasePrivilegeArray) ToDatabasePrivilegeArrayOutputWithContext(ctx context.Context) DatabasePrivilegeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabasePrivilegeArrayOutput)
}

// DatabasePrivilegeMapInput is an input type that accepts DatabasePrivilegeMap and DatabasePrivilegeMapOutput values.
// You can construct a concrete instance of `DatabasePrivilegeMapInput` via:
//
//	DatabasePrivilegeMap{ "key": DatabasePrivilegeArgs{...} }
type DatabasePrivilegeMapInput interface {
	pulumi.Input

	ToDatabasePrivilegeMapOutput() DatabasePrivilegeMapOutput
	ToDatabasePrivilegeMapOutputWithContext(context.Context) DatabasePrivilegeMapOutput
}

type DatabasePrivilegeMap map[string]DatabasePrivilegeInput

func (DatabasePrivilegeMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DatabasePrivilege)(nil)).Elem()
}

func (i DatabasePrivilegeMap) ToDatabasePrivilegeMapOutput() DatabasePrivilegeMapOutput {
	return i.ToDatabasePrivilegeMapOutputWithContext(context.Background())
}

func (i DatabasePrivilegeMap) ToDatabasePrivilegeMapOutputWithContext(ctx context.Context) DatabasePrivilegeMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabasePrivilegeMapOutput)
}

type DatabasePrivilegeOutput struct{ *pulumi.OutputState }

func (DatabasePrivilegeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabasePrivilege)(nil)).Elem()
}

func (o DatabasePrivilegeOutput) ToDatabasePrivilegeOutput() DatabasePrivilegeOutput {
	return o
}

func (o DatabasePrivilegeOutput) ToDatabasePrivilegeOutputWithContext(ctx context.Context) DatabasePrivilegeOutput {
	return o
}

// Database name
func (o DatabasePrivilegeOutput) DatabaseName() pulumi.StringOutput {
	return o.ApplyT(func(v *DatabasePrivilege) pulumi.StringOutput { return v.DatabaseName }).(pulumi.StringOutput)
}

// Instance on which the database is created
func (o DatabasePrivilegeOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *DatabasePrivilege) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Privilege
func (o DatabasePrivilegeOutput) Permission() pulumi.StringOutput {
	return o.ApplyT(func(v *DatabasePrivilege) pulumi.StringOutput { return v.Permission }).(pulumi.StringOutput)
}

// User name
func (o DatabasePrivilegeOutput) UserName() pulumi.StringOutput {
	return o.ApplyT(func(v *DatabasePrivilege) pulumi.StringOutput { return v.UserName }).(pulumi.StringOutput)
}

type DatabasePrivilegeArrayOutput struct{ *pulumi.OutputState }

func (DatabasePrivilegeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DatabasePrivilege)(nil)).Elem()
}

func (o DatabasePrivilegeArrayOutput) ToDatabasePrivilegeArrayOutput() DatabasePrivilegeArrayOutput {
	return o
}

func (o DatabasePrivilegeArrayOutput) ToDatabasePrivilegeArrayOutputWithContext(ctx context.Context) DatabasePrivilegeArrayOutput {
	return o
}

func (o DatabasePrivilegeArrayOutput) Index(i pulumi.IntInput) DatabasePrivilegeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DatabasePrivilege {
		return vs[0].([]*DatabasePrivilege)[vs[1].(int)]
	}).(DatabasePrivilegeOutput)
}

type DatabasePrivilegeMapOutput struct{ *pulumi.OutputState }

func (DatabasePrivilegeMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DatabasePrivilege)(nil)).Elem()
}

func (o DatabasePrivilegeMapOutput) ToDatabasePrivilegeMapOutput() DatabasePrivilegeMapOutput {
	return o
}

func (o DatabasePrivilegeMapOutput) ToDatabasePrivilegeMapOutputWithContext(ctx context.Context) DatabasePrivilegeMapOutput {
	return o
}

func (o DatabasePrivilegeMapOutput) MapIndex(k pulumi.StringInput) DatabasePrivilegeOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DatabasePrivilege {
		return vs[0].(map[string]*DatabasePrivilege)[vs[1].(string)]
	}).(DatabasePrivilegeOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatabasePrivilegeInput)(nil)).Elem(), &DatabasePrivilege{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabasePrivilegeArrayInput)(nil)).Elem(), DatabasePrivilegeArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabasePrivilegeMapInput)(nil)).Elem(), DatabasePrivilegeMap{})
	pulumi.RegisterOutputType(DatabasePrivilegeOutput{})
	pulumi.RegisterOutputType(DatabasePrivilegeArrayOutput{})
	pulumi.RegisterOutputType(DatabasePrivilegeMapOutput{})
}
