// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class GetRegistryNamespaceResult {
    private String description;
    /**
     * @return The endpoint of the Registry Namespace.
     * 
     */
    private String endpoint;
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    private String id;
    /**
     * @return The Namespace Privacy Policy: whether or not the images are public.
     * 
     */
    private Boolean isPublic;
    private @Nullable String name;
    private @Nullable String namespaceId;
    /**
     * @return The organization ID the namespace is associated with.
     * 
     */
    private String organizationId;
    private String projectId;
    private @Nullable String region;

    private GetRegistryNamespaceResult() {}
    public String description() {
        return this.description;
    }
    /**
     * @return The endpoint of the Registry Namespace.
     * 
     */
    public String endpoint() {
        return this.endpoint;
    }
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    public String id() {
        return this.id;
    }
    /**
     * @return The Namespace Privacy Policy: whether or not the images are public.
     * 
     */
    public Boolean isPublic() {
        return this.isPublic;
    }
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }
    public Optional<String> namespaceId() {
        return Optional.ofNullable(this.namespaceId);
    }
    /**
     * @return The organization ID the namespace is associated with.
     * 
     */
    public String organizationId() {
        return this.organizationId;
    }
    public String projectId() {
        return this.projectId;
    }
    public Optional<String> region() {
        return Optional.ofNullable(this.region);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(GetRegistryNamespaceResult defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String description;
        private String endpoint;
        private String id;
        private Boolean isPublic;
        private @Nullable String name;
        private @Nullable String namespaceId;
        private String organizationId;
        private String projectId;
        private @Nullable String region;
        public Builder() {}
        public Builder(GetRegistryNamespaceResult defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.description = defaults.description;
    	      this.endpoint = defaults.endpoint;
    	      this.id = defaults.id;
    	      this.isPublic = defaults.isPublic;
    	      this.name = defaults.name;
    	      this.namespaceId = defaults.namespaceId;
    	      this.organizationId = defaults.organizationId;
    	      this.projectId = defaults.projectId;
    	      this.region = defaults.region;
        }

        @CustomType.Setter
        public Builder description(String description) {
            this.description = Objects.requireNonNull(description);
            return this;
        }
        @CustomType.Setter
        public Builder endpoint(String endpoint) {
            this.endpoint = Objects.requireNonNull(endpoint);
            return this;
        }
        @CustomType.Setter
        public Builder id(String id) {
            this.id = Objects.requireNonNull(id);
            return this;
        }
        @CustomType.Setter
        public Builder isPublic(Boolean isPublic) {
            this.isPublic = Objects.requireNonNull(isPublic);
            return this;
        }
        @CustomType.Setter
        public Builder name(@Nullable String name) {
            this.name = name;
            return this;
        }
        @CustomType.Setter
        public Builder namespaceId(@Nullable String namespaceId) {
            this.namespaceId = namespaceId;
            return this;
        }
        @CustomType.Setter
        public Builder organizationId(String organizationId) {
            this.organizationId = Objects.requireNonNull(organizationId);
            return this;
        }
        @CustomType.Setter
        public Builder projectId(String projectId) {
            this.projectId = Objects.requireNonNull(projectId);
            return this;
        }
        @CustomType.Setter
        public Builder region(@Nullable String region) {
            this.region = region;
            return this;
        }
        public GetRegistryNamespaceResult build() {
            final var o = new GetRegistryNamespaceResult();
            o.description = description;
            o.endpoint = endpoint;
            o.id = id;
            o.isPublic = isPublic;
            o.name = name;
            o.namespaceId = namespaceId;
            o.organizationId = organizationId;
            o.projectId = projectId;
            o.region = region;
            return o;
        }
    }
}
