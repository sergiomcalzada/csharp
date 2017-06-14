// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DeploymentStatus is the most recently observed status of the
    /// Deployment.
    /// </summary>
    public partial class Extensionsv1beta1DeploymentStatus
    {
        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1DeploymentStatus
        /// class.
        /// </summary>
        public Extensionsv1beta1DeploymentStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1DeploymentStatus
        /// class.
        /// </summary>
        /// <param name="availableReplicas">Total number of available pods
        /// (ready for at least minReadySeconds) targeted by this
        /// deployment.</param>
        /// <param name="conditions">Represents the latest available
        /// observations of a deployment's current state.</param>
        /// <param name="observedGeneration">The generation observed by the
        /// deployment controller.</param>
        /// <param name="readyReplicas">Total number of ready pods targeted by
        /// this deployment.</param>
        /// <param name="replicas">Total number of non-terminated pods targeted
        /// by this deployment (their labels match the selector).</param>
        /// <param name="unavailableReplicas">Total number of unavailable pods
        /// targeted by this deployment.</param>
        /// <param name="updatedReplicas">Total number of non-terminated pods
        /// targeted by this deployment that have the desired template
        /// spec.</param>
        public Extensionsv1beta1DeploymentStatus(int? availableReplicas = default(int?), IList<Extensionsv1beta1DeploymentCondition> conditions = default(IList<Extensionsv1beta1DeploymentCondition>), long? observedGeneration = default(long?), int? readyReplicas = default(int?), int? replicas = default(int?), int? unavailableReplicas = default(int?), int? updatedReplicas = default(int?))
        {
            AvailableReplicas = availableReplicas;
            Conditions = conditions;
            ObservedGeneration = observedGeneration;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            UnavailableReplicas = unavailableReplicas;
            UpdatedReplicas = updatedReplicas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets total number of available pods (ready for at least
        /// minReadySeconds) targeted by this deployment.
        /// </summary>
        [JsonProperty(PropertyName = "availableReplicas")]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Gets or sets represents the latest available observations of a
        /// deployment's current state.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Extensionsv1beta1DeploymentCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the generation observed by the deployment controller.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// Gets or sets total number of ready pods targeted by this
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Gets or sets total number of non-terminated pods targeted by this
        /// deployment (their labels match the selector).
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Gets or sets total number of unavailable pods targeted by this
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "unavailableReplicas")]
        public int? UnavailableReplicas { get; set; }

        /// <summary>
        /// Gets or sets total number of non-terminated pods targeted by this
        /// deployment that have the desired template spec.
        /// </summary>
        [JsonProperty(PropertyName = "updatedReplicas")]
        public int? UpdatedReplicas { get; set; }

    }
}