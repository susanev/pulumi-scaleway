// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class CockpitTokenScopesArgs extends com.pulumi.resources.ResourceArgs {

    public static final CockpitTokenScopesArgs Empty = new CockpitTokenScopesArgs();

    /**
     * Query logs
     * 
     */
    @Import(name="queryLogs")
    private @Nullable Output<Boolean> queryLogs;

    /**
     * @return Query logs
     * 
     */
    public Optional<Output<Boolean>> queryLogs() {
        return Optional.ofNullable(this.queryLogs);
    }

    /**
     * Query metrics
     * 
     */
    @Import(name="queryMetrics")
    private @Nullable Output<Boolean> queryMetrics;

    /**
     * @return Query metrics
     * 
     */
    public Optional<Output<Boolean>> queryMetrics() {
        return Optional.ofNullable(this.queryMetrics);
    }

    /**
     * Setup alerts
     * 
     */
    @Import(name="setupAlerts")
    private @Nullable Output<Boolean> setupAlerts;

    /**
     * @return Setup alerts
     * 
     */
    public Optional<Output<Boolean>> setupAlerts() {
        return Optional.ofNullable(this.setupAlerts);
    }

    /**
     * Setup logs rules
     * 
     */
    @Import(name="setupLogsRules")
    private @Nullable Output<Boolean> setupLogsRules;

    /**
     * @return Setup logs rules
     * 
     */
    public Optional<Output<Boolean>> setupLogsRules() {
        return Optional.ofNullable(this.setupLogsRules);
    }

    /**
     * Setup metrics rules
     * 
     */
    @Import(name="setupMetricsRules")
    private @Nullable Output<Boolean> setupMetricsRules;

    /**
     * @return Setup metrics rules
     * 
     */
    public Optional<Output<Boolean>> setupMetricsRules() {
        return Optional.ofNullable(this.setupMetricsRules);
    }

    /**
     * Write logs
     * 
     */
    @Import(name="writeLogs")
    private @Nullable Output<Boolean> writeLogs;

    /**
     * @return Write logs
     * 
     */
    public Optional<Output<Boolean>> writeLogs() {
        return Optional.ofNullable(this.writeLogs);
    }

    /**
     * Write metrics
     * 
     */
    @Import(name="writeMetrics")
    private @Nullable Output<Boolean> writeMetrics;

    /**
     * @return Write metrics
     * 
     */
    public Optional<Output<Boolean>> writeMetrics() {
        return Optional.ofNullable(this.writeMetrics);
    }

    private CockpitTokenScopesArgs() {}

    private CockpitTokenScopesArgs(CockpitTokenScopesArgs $) {
        this.queryLogs = $.queryLogs;
        this.queryMetrics = $.queryMetrics;
        this.setupAlerts = $.setupAlerts;
        this.setupLogsRules = $.setupLogsRules;
        this.setupMetricsRules = $.setupMetricsRules;
        this.writeLogs = $.writeLogs;
        this.writeMetrics = $.writeMetrics;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(CockpitTokenScopesArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private CockpitTokenScopesArgs $;

        public Builder() {
            $ = new CockpitTokenScopesArgs();
        }

        public Builder(CockpitTokenScopesArgs defaults) {
            $ = new CockpitTokenScopesArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param queryLogs Query logs
         * 
         * @return builder
         * 
         */
        public Builder queryLogs(@Nullable Output<Boolean> queryLogs) {
            $.queryLogs = queryLogs;
            return this;
        }

        /**
         * @param queryLogs Query logs
         * 
         * @return builder
         * 
         */
        public Builder queryLogs(Boolean queryLogs) {
            return queryLogs(Output.of(queryLogs));
        }

        /**
         * @param queryMetrics Query metrics
         * 
         * @return builder
         * 
         */
        public Builder queryMetrics(@Nullable Output<Boolean> queryMetrics) {
            $.queryMetrics = queryMetrics;
            return this;
        }

        /**
         * @param queryMetrics Query metrics
         * 
         * @return builder
         * 
         */
        public Builder queryMetrics(Boolean queryMetrics) {
            return queryMetrics(Output.of(queryMetrics));
        }

        /**
         * @param setupAlerts Setup alerts
         * 
         * @return builder
         * 
         */
        public Builder setupAlerts(@Nullable Output<Boolean> setupAlerts) {
            $.setupAlerts = setupAlerts;
            return this;
        }

        /**
         * @param setupAlerts Setup alerts
         * 
         * @return builder
         * 
         */
        public Builder setupAlerts(Boolean setupAlerts) {
            return setupAlerts(Output.of(setupAlerts));
        }

        /**
         * @param setupLogsRules Setup logs rules
         * 
         * @return builder
         * 
         */
        public Builder setupLogsRules(@Nullable Output<Boolean> setupLogsRules) {
            $.setupLogsRules = setupLogsRules;
            return this;
        }

        /**
         * @param setupLogsRules Setup logs rules
         * 
         * @return builder
         * 
         */
        public Builder setupLogsRules(Boolean setupLogsRules) {
            return setupLogsRules(Output.of(setupLogsRules));
        }

        /**
         * @param setupMetricsRules Setup metrics rules
         * 
         * @return builder
         * 
         */
        public Builder setupMetricsRules(@Nullable Output<Boolean> setupMetricsRules) {
            $.setupMetricsRules = setupMetricsRules;
            return this;
        }

        /**
         * @param setupMetricsRules Setup metrics rules
         * 
         * @return builder
         * 
         */
        public Builder setupMetricsRules(Boolean setupMetricsRules) {
            return setupMetricsRules(Output.of(setupMetricsRules));
        }

        /**
         * @param writeLogs Write logs
         * 
         * @return builder
         * 
         */
        public Builder writeLogs(@Nullable Output<Boolean> writeLogs) {
            $.writeLogs = writeLogs;
            return this;
        }

        /**
         * @param writeLogs Write logs
         * 
         * @return builder
         * 
         */
        public Builder writeLogs(Boolean writeLogs) {
            return writeLogs(Output.of(writeLogs));
        }

        /**
         * @param writeMetrics Write metrics
         * 
         * @return builder
         * 
         */
        public Builder writeMetrics(@Nullable Output<Boolean> writeMetrics) {
            $.writeMetrics = writeMetrics;
            return this;
        }

        /**
         * @param writeMetrics Write metrics
         * 
         * @return builder
         * 
         */
        public Builder writeMetrics(Boolean writeMetrics) {
            return writeMetrics(Output.of(writeMetrics));
        }

        public CockpitTokenScopesArgs build() {
            return $;
        }
    }

}