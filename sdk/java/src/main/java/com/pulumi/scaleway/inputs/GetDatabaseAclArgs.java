// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GetDatabaseAclArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetDatabaseAclArgs Empty = new GetDatabaseAclArgs();

    /**
     * The RDB instance ID.
     * 
     */
    @Import(name="instanceId", required=true)
    private Output<String> instanceId;

    /**
     * @return The RDB instance ID.
     * 
     */
    public Output<String> instanceId() {
        return this.instanceId;
    }

    /**
     * `region`) The region in which the Database Instance should be created.
     * 
     */
    @Import(name="region")
    private @Nullable Output<String> region;

    /**
     * @return `region`) The region in which the Database Instance should be created.
     * 
     */
    public Optional<Output<String>> region() {
        return Optional.ofNullable(this.region);
    }

    private GetDatabaseAclArgs() {}

    private GetDatabaseAclArgs(GetDatabaseAclArgs $) {
        this.instanceId = $.instanceId;
        this.region = $.region;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetDatabaseAclArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetDatabaseAclArgs $;

        public Builder() {
            $ = new GetDatabaseAclArgs();
        }

        public Builder(GetDatabaseAclArgs defaults) {
            $ = new GetDatabaseAclArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param instanceId The RDB instance ID.
         * 
         * @return builder
         * 
         */
        public Builder instanceId(Output<String> instanceId) {
            $.instanceId = instanceId;
            return this;
        }

        /**
         * @param instanceId The RDB instance ID.
         * 
         * @return builder
         * 
         */
        public Builder instanceId(String instanceId) {
            return instanceId(Output.of(instanceId));
        }

        /**
         * @param region `region`) The region in which the Database Instance should be created.
         * 
         * @return builder
         * 
         */
        public Builder region(@Nullable Output<String> region) {
            $.region = region;
            return this;
        }

        /**
         * @param region `region`) The region in which the Database Instance should be created.
         * 
         * @return builder
         * 
         */
        public Builder region(String region) {
            return region(Output.of(region));
        }

        public GetDatabaseAclArgs build() {
            $.instanceId = Objects.requireNonNull($.instanceId, "expected parameter 'instanceId' to be non-null");
            return $;
        }
    }

}
