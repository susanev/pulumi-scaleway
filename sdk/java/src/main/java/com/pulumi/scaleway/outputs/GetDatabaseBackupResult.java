// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.Integer;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class GetDatabaseBackupResult {
    private @Nullable String backupId;
    private String createdAt;
    private String databaseName;
    private String expiresAt;
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    private String id;
    private @Nullable String instanceId;
    private String instanceName;
    private @Nullable String name;
    private @Nullable String region;
    private Integer size;
    private String updatedAt;

    private GetDatabaseBackupResult() {}
    public Optional<String> backupId() {
        return Optional.ofNullable(this.backupId);
    }
    public String createdAt() {
        return this.createdAt;
    }
    public String databaseName() {
        return this.databaseName;
    }
    public String expiresAt() {
        return this.expiresAt;
    }
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    public String id() {
        return this.id;
    }
    public Optional<String> instanceId() {
        return Optional.ofNullable(this.instanceId);
    }
    public String instanceName() {
        return this.instanceName;
    }
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }
    public Optional<String> region() {
        return Optional.ofNullable(this.region);
    }
    public Integer size() {
        return this.size;
    }
    public String updatedAt() {
        return this.updatedAt;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(GetDatabaseBackupResult defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable String backupId;
        private String createdAt;
        private String databaseName;
        private String expiresAt;
        private String id;
        private @Nullable String instanceId;
        private String instanceName;
        private @Nullable String name;
        private @Nullable String region;
        private Integer size;
        private String updatedAt;
        public Builder() {}
        public Builder(GetDatabaseBackupResult defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.backupId = defaults.backupId;
    	      this.createdAt = defaults.createdAt;
    	      this.databaseName = defaults.databaseName;
    	      this.expiresAt = defaults.expiresAt;
    	      this.id = defaults.id;
    	      this.instanceId = defaults.instanceId;
    	      this.instanceName = defaults.instanceName;
    	      this.name = defaults.name;
    	      this.region = defaults.region;
    	      this.size = defaults.size;
    	      this.updatedAt = defaults.updatedAt;
        }

        @CustomType.Setter
        public Builder backupId(@Nullable String backupId) {
            this.backupId = backupId;
            return this;
        }
        @CustomType.Setter
        public Builder createdAt(String createdAt) {
            this.createdAt = Objects.requireNonNull(createdAt);
            return this;
        }
        @CustomType.Setter
        public Builder databaseName(String databaseName) {
            this.databaseName = Objects.requireNonNull(databaseName);
            return this;
        }
        @CustomType.Setter
        public Builder expiresAt(String expiresAt) {
            this.expiresAt = Objects.requireNonNull(expiresAt);
            return this;
        }
        @CustomType.Setter
        public Builder id(String id) {
            this.id = Objects.requireNonNull(id);
            return this;
        }
        @CustomType.Setter
        public Builder instanceId(@Nullable String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        @CustomType.Setter
        public Builder instanceName(String instanceName) {
            this.instanceName = Objects.requireNonNull(instanceName);
            return this;
        }
        @CustomType.Setter
        public Builder name(@Nullable String name) {
            this.name = name;
            return this;
        }
        @CustomType.Setter
        public Builder region(@Nullable String region) {
            this.region = region;
            return this;
        }
        @CustomType.Setter
        public Builder size(Integer size) {
            this.size = Objects.requireNonNull(size);
            return this;
        }
        @CustomType.Setter
        public Builder updatedAt(String updatedAt) {
            this.updatedAt = Objects.requireNonNull(updatedAt);
            return this;
        }
        public GetDatabaseBackupResult build() {
            final var o = new GetDatabaseBackupResult();
            o.backupId = backupId;
            o.createdAt = createdAt;
            o.databaseName = databaseName;
            o.expiresAt = expiresAt;
            o.id = id;
            o.instanceId = instanceId;
            o.instanceName = instanceName;
            o.name = name;
            o.region = region;
            o.size = size;
            o.updatedAt = updatedAt;
            return o;
        }
    }
}