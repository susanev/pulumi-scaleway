// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class ObjectBucketPolicyState extends com.pulumi.resources.ResourceArgs {

    public static final ObjectBucketPolicyState Empty = new ObjectBucketPolicyState();

    /**
     * The name of the bucket.
     * 
     */
    @Import(name="bucket")
    private @Nullable Output<String> bucket;

    /**
     * @return The name of the bucket.
     * 
     */
    public Optional<Output<String>> bucket() {
        return Optional.ofNullable(this.bucket);
    }

    /**
     * The text of the policy.
     * 
     */
    @Import(name="policy")
    private @Nullable Output<String> policy;

    /**
     * @return The text of the policy.
     * 
     */
    public Optional<Output<String>> policy() {
        return Optional.ofNullable(this.policy);
    }

    /**
     * The Scaleway region this bucket resides in.
     * 
     */
    @Import(name="region")
    private @Nullable Output<String> region;

    /**
     * @return The Scaleway region this bucket resides in.
     * 
     */
    public Optional<Output<String>> region() {
        return Optional.ofNullable(this.region);
    }

    private ObjectBucketPolicyState() {}

    private ObjectBucketPolicyState(ObjectBucketPolicyState $) {
        this.bucket = $.bucket;
        this.policy = $.policy;
        this.region = $.region;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(ObjectBucketPolicyState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private ObjectBucketPolicyState $;

        public Builder() {
            $ = new ObjectBucketPolicyState();
        }

        public Builder(ObjectBucketPolicyState defaults) {
            $ = new ObjectBucketPolicyState(Objects.requireNonNull(defaults));
        }

        /**
         * @param bucket The name of the bucket.
         * 
         * @return builder
         * 
         */
        public Builder bucket(@Nullable Output<String> bucket) {
            $.bucket = bucket;
            return this;
        }

        /**
         * @param bucket The name of the bucket.
         * 
         * @return builder
         * 
         */
        public Builder bucket(String bucket) {
            return bucket(Output.of(bucket));
        }

        /**
         * @param policy The text of the policy.
         * 
         * @return builder
         * 
         */
        public Builder policy(@Nullable Output<String> policy) {
            $.policy = policy;
            return this;
        }

        /**
         * @param policy The text of the policy.
         * 
         * @return builder
         * 
         */
        public Builder policy(String policy) {
            return policy(Output.of(policy));
        }

        /**
         * @param region The Scaleway region this bucket resides in.
         * 
         * @return builder
         * 
         */
        public Builder region(@Nullable Output<String> region) {
            $.region = region;
            return this;
        }

        /**
         * @param region The Scaleway region this bucket resides in.
         * 
         * @return builder
         * 
         */
        public Builder region(String region) {
            return region(Output.of(region));
        }

        public ObjectBucketPolicyState build() {
            return $;
        }
    }

}