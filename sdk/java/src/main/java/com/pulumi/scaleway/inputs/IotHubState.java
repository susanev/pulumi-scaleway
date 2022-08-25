// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.Integer;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class IotHubState extends com.pulumi.resources.ResourceArgs {

    public static final IotHubState Empty = new IotHubState();

    /**
     * The current number of connected devices in the Hub.
     * 
     */
    @Import(name="connectedDeviceCount")
    private @Nullable Output<Integer> connectedDeviceCount;

    /**
     * @return The current number of connected devices in the Hub.
     * 
     */
    public Optional<Output<Integer>> connectedDeviceCount() {
        return Optional.ofNullable(this.connectedDeviceCount);
    }

    /**
     * The date and time the Hub was created.
     * 
     */
    @Import(name="createdAt")
    private @Nullable Output<String> createdAt;

    /**
     * @return The date and time the Hub was created.
     * 
     */
    public Optional<Output<String>> createdAt() {
        return Optional.ofNullable(this.createdAt);
    }

    /**
     * Wether to enable the device auto provisioning or not
     * 
     */
    @Import(name="deviceAutoProvisioning")
    private @Nullable Output<Boolean> deviceAutoProvisioning;

    /**
     * @return Wether to enable the device auto provisioning or not
     * 
     */
    public Optional<Output<Boolean>> deviceAutoProvisioning() {
        return Optional.ofNullable(this.deviceAutoProvisioning);
    }

    /**
     * The number of registered devices in the Hub.
     * 
     */
    @Import(name="deviceCount")
    private @Nullable Output<Integer> deviceCount;

    /**
     * @return The number of registered devices in the Hub.
     * 
     */
    public Optional<Output<Integer>> deviceCount() {
        return Optional.ofNullable(this.deviceCount);
    }

    /**
     * Whether to enable the hub events or not
     * 
     */
    @Import(name="disableEvents")
    private @Nullable Output<Boolean> disableEvents;

    /**
     * @return Whether to enable the hub events or not
     * 
     */
    public Optional<Output<Boolean>> disableEvents() {
        return Optional.ofNullable(this.disableEvents);
    }

    /**
     * Wether the IoT Hub instance should be enabled or not.
     * 
     */
    @Import(name="enabled")
    private @Nullable Output<Boolean> enabled;

    /**
     * @return Wether the IoT Hub instance should be enabled or not.
     * 
     */
    public Optional<Output<Boolean>> enabled() {
        return Optional.ofNullable(this.enabled);
    }

    /**
     * The MQTT network endpoint to connect MQTT devices to.
     * 
     */
    @Import(name="endpoint")
    private @Nullable Output<String> endpoint;

    /**
     * @return The MQTT network endpoint to connect MQTT devices to.
     * 
     */
    public Optional<Output<String>> endpoint() {
        return Optional.ofNullable(this.endpoint);
    }

    /**
     * Topic prefix for the hub events
     * 
     */
    @Import(name="eventsTopicPrefix")
    private @Nullable Output<String> eventsTopicPrefix;

    /**
     * @return Topic prefix for the hub events
     * 
     */
    public Optional<Output<String>> eventsTopicPrefix() {
        return Optional.ofNullable(this.eventsTopicPrefix);
    }

    /**
     * Custom user provided certificate authority
     * 
     */
    @Import(name="hubCa")
    private @Nullable Output<String> hubCa;

    /**
     * @return Custom user provided certificate authority
     * 
     */
    public Optional<Output<String>> hubCa() {
        return Optional.ofNullable(this.hubCa);
    }

    /**
     * Challenge certificate for the user provided hub CA
     * 
     */
    @Import(name="hubCaChallenge")
    private @Nullable Output<String> hubCaChallenge;

    /**
     * @return Challenge certificate for the user provided hub CA
     * 
     */
    public Optional<Output<String>> hubCaChallenge() {
        return Optional.ofNullable(this.hubCaChallenge);
    }

    /**
     * The name of the IoT Hub instance you want to create (e.g. `my-hub`).
     * 
     */
    @Import(name="name")
    private @Nullable Output<String> name;

    /**
     * @return The name of the IoT Hub instance you want to create (e.g. `my-hub`).
     * 
     */
    public Optional<Output<String>> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * The organization_id you want to attach the resource to
     * 
     */
    @Import(name="organizationId")
    private @Nullable Output<String> organizationId;

    /**
     * @return The organization_id you want to attach the resource to
     * 
     */
    public Optional<Output<String>> organizationId() {
        return Optional.ofNullable(this.organizationId);
    }

    /**
     * Product plan to create the hub, see documentation for available product plans (e.g. `plan_shared`)
     * 
     */
    @Import(name="productPlan")
    private @Nullable Output<String> productPlan;

    /**
     * @return Product plan to create the hub, see documentation for available product plans (e.g. `plan_shared`)
     * 
     */
    public Optional<Output<String>> productPlan() {
        return Optional.ofNullable(this.productPlan);
    }

    /**
     * `project_id`) The ID of the project the IoT Hub Instance is associated with.
     * 
     */
    @Import(name="projectId")
    private @Nullable Output<String> projectId;

    /**
     * @return `project_id`) The ID of the project the IoT Hub Instance is associated with.
     * 
     */
    public Optional<Output<String>> projectId() {
        return Optional.ofNullable(this.projectId);
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

    /**
     * The current status of the Hub.
     * 
     */
    @Import(name="status")
    private @Nullable Output<String> status;

    /**
     * @return The current status of the Hub.
     * 
     */
    public Optional<Output<String>> status() {
        return Optional.ofNullable(this.status);
    }

    /**
     * The date and time the Hub resource was updated.
     * 
     */
    @Import(name="updatedAt")
    private @Nullable Output<String> updatedAt;

    /**
     * @return The date and time the Hub resource was updated.
     * 
     */
    public Optional<Output<String>> updatedAt() {
        return Optional.ofNullable(this.updatedAt);
    }

    private IotHubState() {}

    private IotHubState(IotHubState $) {
        this.connectedDeviceCount = $.connectedDeviceCount;
        this.createdAt = $.createdAt;
        this.deviceAutoProvisioning = $.deviceAutoProvisioning;
        this.deviceCount = $.deviceCount;
        this.disableEvents = $.disableEvents;
        this.enabled = $.enabled;
        this.endpoint = $.endpoint;
        this.eventsTopicPrefix = $.eventsTopicPrefix;
        this.hubCa = $.hubCa;
        this.hubCaChallenge = $.hubCaChallenge;
        this.name = $.name;
        this.organizationId = $.organizationId;
        this.productPlan = $.productPlan;
        this.projectId = $.projectId;
        this.region = $.region;
        this.status = $.status;
        this.updatedAt = $.updatedAt;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(IotHubState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private IotHubState $;

        public Builder() {
            $ = new IotHubState();
        }

        public Builder(IotHubState defaults) {
            $ = new IotHubState(Objects.requireNonNull(defaults));
        }

        /**
         * @param connectedDeviceCount The current number of connected devices in the Hub.
         * 
         * @return builder
         * 
         */
        public Builder connectedDeviceCount(@Nullable Output<Integer> connectedDeviceCount) {
            $.connectedDeviceCount = connectedDeviceCount;
            return this;
        }

        /**
         * @param connectedDeviceCount The current number of connected devices in the Hub.
         * 
         * @return builder
         * 
         */
        public Builder connectedDeviceCount(Integer connectedDeviceCount) {
            return connectedDeviceCount(Output.of(connectedDeviceCount));
        }

        /**
         * @param createdAt The date and time the Hub was created.
         * 
         * @return builder
         * 
         */
        public Builder createdAt(@Nullable Output<String> createdAt) {
            $.createdAt = createdAt;
            return this;
        }

        /**
         * @param createdAt The date and time the Hub was created.
         * 
         * @return builder
         * 
         */
        public Builder createdAt(String createdAt) {
            return createdAt(Output.of(createdAt));
        }

        /**
         * @param deviceAutoProvisioning Wether to enable the device auto provisioning or not
         * 
         * @return builder
         * 
         */
        public Builder deviceAutoProvisioning(@Nullable Output<Boolean> deviceAutoProvisioning) {
            $.deviceAutoProvisioning = deviceAutoProvisioning;
            return this;
        }

        /**
         * @param deviceAutoProvisioning Wether to enable the device auto provisioning or not
         * 
         * @return builder
         * 
         */
        public Builder deviceAutoProvisioning(Boolean deviceAutoProvisioning) {
            return deviceAutoProvisioning(Output.of(deviceAutoProvisioning));
        }

        /**
         * @param deviceCount The number of registered devices in the Hub.
         * 
         * @return builder
         * 
         */
        public Builder deviceCount(@Nullable Output<Integer> deviceCount) {
            $.deviceCount = deviceCount;
            return this;
        }

        /**
         * @param deviceCount The number of registered devices in the Hub.
         * 
         * @return builder
         * 
         */
        public Builder deviceCount(Integer deviceCount) {
            return deviceCount(Output.of(deviceCount));
        }

        /**
         * @param disableEvents Whether to enable the hub events or not
         * 
         * @return builder
         * 
         */
        public Builder disableEvents(@Nullable Output<Boolean> disableEvents) {
            $.disableEvents = disableEvents;
            return this;
        }

        /**
         * @param disableEvents Whether to enable the hub events or not
         * 
         * @return builder
         * 
         */
        public Builder disableEvents(Boolean disableEvents) {
            return disableEvents(Output.of(disableEvents));
        }

        /**
         * @param enabled Wether the IoT Hub instance should be enabled or not.
         * 
         * @return builder
         * 
         */
        public Builder enabled(@Nullable Output<Boolean> enabled) {
            $.enabled = enabled;
            return this;
        }

        /**
         * @param enabled Wether the IoT Hub instance should be enabled or not.
         * 
         * @return builder
         * 
         */
        public Builder enabled(Boolean enabled) {
            return enabled(Output.of(enabled));
        }

        /**
         * @param endpoint The MQTT network endpoint to connect MQTT devices to.
         * 
         * @return builder
         * 
         */
        public Builder endpoint(@Nullable Output<String> endpoint) {
            $.endpoint = endpoint;
            return this;
        }

        /**
         * @param endpoint The MQTT network endpoint to connect MQTT devices to.
         * 
         * @return builder
         * 
         */
        public Builder endpoint(String endpoint) {
            return endpoint(Output.of(endpoint));
        }

        /**
         * @param eventsTopicPrefix Topic prefix for the hub events
         * 
         * @return builder
         * 
         */
        public Builder eventsTopicPrefix(@Nullable Output<String> eventsTopicPrefix) {
            $.eventsTopicPrefix = eventsTopicPrefix;
            return this;
        }

        /**
         * @param eventsTopicPrefix Topic prefix for the hub events
         * 
         * @return builder
         * 
         */
        public Builder eventsTopicPrefix(String eventsTopicPrefix) {
            return eventsTopicPrefix(Output.of(eventsTopicPrefix));
        }

        /**
         * @param hubCa Custom user provided certificate authority
         * 
         * @return builder
         * 
         */
        public Builder hubCa(@Nullable Output<String> hubCa) {
            $.hubCa = hubCa;
            return this;
        }

        /**
         * @param hubCa Custom user provided certificate authority
         * 
         * @return builder
         * 
         */
        public Builder hubCa(String hubCa) {
            return hubCa(Output.of(hubCa));
        }

        /**
         * @param hubCaChallenge Challenge certificate for the user provided hub CA
         * 
         * @return builder
         * 
         */
        public Builder hubCaChallenge(@Nullable Output<String> hubCaChallenge) {
            $.hubCaChallenge = hubCaChallenge;
            return this;
        }

        /**
         * @param hubCaChallenge Challenge certificate for the user provided hub CA
         * 
         * @return builder
         * 
         */
        public Builder hubCaChallenge(String hubCaChallenge) {
            return hubCaChallenge(Output.of(hubCaChallenge));
        }

        /**
         * @param name The name of the IoT Hub instance you want to create (e.g. `my-hub`).
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable Output<String> name) {
            $.name = name;
            return this;
        }

        /**
         * @param name The name of the IoT Hub instance you want to create (e.g. `my-hub`).
         * 
         * @return builder
         * 
         */
        public Builder name(String name) {
            return name(Output.of(name));
        }

        /**
         * @param organizationId The organization_id you want to attach the resource to
         * 
         * @return builder
         * 
         */
        public Builder organizationId(@Nullable Output<String> organizationId) {
            $.organizationId = organizationId;
            return this;
        }

        /**
         * @param organizationId The organization_id you want to attach the resource to
         * 
         * @return builder
         * 
         */
        public Builder organizationId(String organizationId) {
            return organizationId(Output.of(organizationId));
        }

        /**
         * @param productPlan Product plan to create the hub, see documentation for available product plans (e.g. `plan_shared`)
         * 
         * @return builder
         * 
         */
        public Builder productPlan(@Nullable Output<String> productPlan) {
            $.productPlan = productPlan;
            return this;
        }

        /**
         * @param productPlan Product plan to create the hub, see documentation for available product plans (e.g. `plan_shared`)
         * 
         * @return builder
         * 
         */
        public Builder productPlan(String productPlan) {
            return productPlan(Output.of(productPlan));
        }

        /**
         * @param projectId `project_id`) The ID of the project the IoT Hub Instance is associated with.
         * 
         * @return builder
         * 
         */
        public Builder projectId(@Nullable Output<String> projectId) {
            $.projectId = projectId;
            return this;
        }

        /**
         * @param projectId `project_id`) The ID of the project the IoT Hub Instance is associated with.
         * 
         * @return builder
         * 
         */
        public Builder projectId(String projectId) {
            return projectId(Output.of(projectId));
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

        /**
         * @param status The current status of the Hub.
         * 
         * @return builder
         * 
         */
        public Builder status(@Nullable Output<String> status) {
            $.status = status;
            return this;
        }

        /**
         * @param status The current status of the Hub.
         * 
         * @return builder
         * 
         */
        public Builder status(String status) {
            return status(Output.of(status));
        }

        /**
         * @param updatedAt The date and time the Hub resource was updated.
         * 
         * @return builder
         * 
         */
        public Builder updatedAt(@Nullable Output<String> updatedAt) {
            $.updatedAt = updatedAt;
            return this;
        }

        /**
         * @param updatedAt The date and time the Hub resource was updated.
         * 
         * @return builder
         * 
         */
        public Builder updatedAt(String updatedAt) {
            return updatedAt(Output.of(updatedAt));
        }

        public IotHubState build() {
            return $;
        }
    }

}