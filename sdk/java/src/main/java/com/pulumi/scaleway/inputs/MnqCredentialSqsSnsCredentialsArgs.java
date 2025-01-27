// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.scaleway.inputs.MnqCredentialSqsSnsCredentialsPermissionsArgs;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class MnqCredentialSqsSnsCredentialsArgs extends com.pulumi.resources.ResourceArgs {

    public static final MnqCredentialSqsSnsCredentialsArgs Empty = new MnqCredentialSqsSnsCredentialsArgs();

    /**
     * The ID of the key.
     * 
     */
    @Import(name="accessKey")
    private @Nullable Output<String> accessKey;

    /**
     * @return The ID of the key.
     * 
     */
    public Optional<Output<String>> accessKey() {
        return Optional.ofNullable(this.accessKey);
    }

    /**
     * List of permissions associated to this Credential. Only one of permissions may be set.
     * 
     */
    @Import(name="permissions")
    private @Nullable Output<MnqCredentialSqsSnsCredentialsPermissionsArgs> permissions;

    /**
     * @return List of permissions associated to this Credential. Only one of permissions may be set.
     * 
     */
    public Optional<Output<MnqCredentialSqsSnsCredentialsPermissionsArgs>> permissions() {
        return Optional.ofNullable(this.permissions);
    }

    /**
     * The Secret value of the key.
     * 
     */
    @Import(name="secretKey")
    private @Nullable Output<String> secretKey;

    /**
     * @return The Secret value of the key.
     * 
     */
    public Optional<Output<String>> secretKey() {
        return Optional.ofNullable(this.secretKey);
    }

    private MnqCredentialSqsSnsCredentialsArgs() {}

    private MnqCredentialSqsSnsCredentialsArgs(MnqCredentialSqsSnsCredentialsArgs $) {
        this.accessKey = $.accessKey;
        this.permissions = $.permissions;
        this.secretKey = $.secretKey;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(MnqCredentialSqsSnsCredentialsArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private MnqCredentialSqsSnsCredentialsArgs $;

        public Builder() {
            $ = new MnqCredentialSqsSnsCredentialsArgs();
        }

        public Builder(MnqCredentialSqsSnsCredentialsArgs defaults) {
            $ = new MnqCredentialSqsSnsCredentialsArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param accessKey The ID of the key.
         * 
         * @return builder
         * 
         */
        public Builder accessKey(@Nullable Output<String> accessKey) {
            $.accessKey = accessKey;
            return this;
        }

        /**
         * @param accessKey The ID of the key.
         * 
         * @return builder
         * 
         */
        public Builder accessKey(String accessKey) {
            return accessKey(Output.of(accessKey));
        }

        /**
         * @param permissions List of permissions associated to this Credential. Only one of permissions may be set.
         * 
         * @return builder
         * 
         */
        public Builder permissions(@Nullable Output<MnqCredentialSqsSnsCredentialsPermissionsArgs> permissions) {
            $.permissions = permissions;
            return this;
        }

        /**
         * @param permissions List of permissions associated to this Credential. Only one of permissions may be set.
         * 
         * @return builder
         * 
         */
        public Builder permissions(MnqCredentialSqsSnsCredentialsPermissionsArgs permissions) {
            return permissions(Output.of(permissions));
        }

        /**
         * @param secretKey The Secret value of the key.
         * 
         * @return builder
         * 
         */
        public Builder secretKey(@Nullable Output<String> secretKey) {
            $.secretKey = secretKey;
            return this;
        }

        /**
         * @param secretKey The Secret value of the key.
         * 
         * @return builder
         * 
         */
        public Builder secretKey(String secretKey) {
            return secretKey(Output.of(secretKey));
        }

        public MnqCredentialSqsSnsCredentialsArgs build() {
            return $;
        }
    }

}
