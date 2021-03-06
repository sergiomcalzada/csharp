// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// JobSpec describes how the job execution will look like.
    /// </summary>
    public partial class V1JobSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1JobSpec class.
        /// </summary>
        public V1JobSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1JobSpec class.
        /// </summary>
        /// <param name="template">Template is the object that describes the
        /// pod that will be created when executing a job. More info:
        /// http://kubernetes.io/docs/user-guide/jobs</param>
        /// <param name="activeDeadlineSeconds">Optional duration in seconds
        /// relative to the startTime that the job may be active before the
        /// system tries to terminate it; value must be positive
        /// integer</param>
        /// <param name="completions">Completions specifies the desired number
        /// of successfully finished pods the job should be run with.  Setting
        /// to nil means that the success of any pod signals the success of all
        /// pods, and allows parallelism to have any positive value.  Setting
        /// to 1 means that parallelism is limited to 1 and the success of that
        /// pod signals the success of the job. More info:
        /// http://kubernetes.io/docs/user-guide/jobs</param>
        /// <param name="manualSelector">ManualSelector controls generation of
        /// pod labels and pod selectors. Leave `manualSelector` unset unless
        /// you are certain what you are doing. When false or unset, the system
        /// pick labels unique to this job and appends those labels to the pod
        /// template.  When true, the user is responsible for picking unique
        /// labels and specifying the selector.  Failure to pick a unique label
        /// may cause this and other jobs to not function correctly.  However,
        /// You may see `manualSelector=true` in jobs that were created with
        /// the old `extensions/v1beta1` API. More info:
        /// http://releases.k8s.io/HEAD/docs/design/selector-generation.md</param>
        /// <param name="parallelism">Parallelism specifies the maximum desired
        /// number of pods the job should run at any given time. The actual
        /// number of pods running in steady state will be less than this
        /// number when ((.spec.completions - .status.successful) &lt;
        /// .spec.parallelism), i.e. when the work left to do is less than max
        /// parallelism. More info:
        /// http://kubernetes.io/docs/user-guide/jobs</param>
        /// <param name="selector">Selector is a label query over pods that
        /// should match the pod count. Normally, the system sets this field
        /// for you. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors</param>
        public V1JobSpec(V1PodTemplateSpec template, long? activeDeadlineSeconds = default(long?), int? completions = default(int?), bool? manualSelector = default(bool?), int? parallelism = default(int?), V1LabelSelector selector = default(V1LabelSelector))
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Completions = completions;
            ManualSelector = manualSelector;
            Parallelism = parallelism;
            Selector = selector;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional duration in seconds relative to the startTime
        /// that the job may be active before the system tries to terminate it;
        /// value must be positive integer
        /// </summary>
        [JsonProperty(PropertyName = "activeDeadlineSeconds")]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Gets or sets completions specifies the desired number of
        /// successfully finished pods the job should be run with.  Setting to
        /// nil means that the success of any pod signals the success of all
        /// pods, and allows parallelism to have any positive value.  Setting
        /// to 1 means that parallelism is limited to 1 and the success of that
        /// pod signals the success of the job. More info:
        /// http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        [JsonProperty(PropertyName = "completions")]
        public int? Completions { get; set; }

        /// <summary>
        /// Gets or sets manualSelector controls generation of pod labels and
        /// pod selectors. Leave `manualSelector` unset unless you are certain
        /// what you are doing. When false or unset, the system pick labels
        /// unique to this job and appends those labels to the pod template.
        /// When true, the user is responsible for picking unique labels and
        /// specifying the selector.  Failure to pick a unique label may cause
        /// this and other jobs to not function correctly.  However, You may
        /// see `manualSelector=true` in jobs that were created with the old
        /// `extensions/v1beta1` API. More info:
        /// http://releases.k8s.io/HEAD/docs/design/selector-generation.md
        /// </summary>
        [JsonProperty(PropertyName = "manualSelector")]
        public bool? ManualSelector { get; set; }

        /// <summary>
        /// Gets or sets parallelism specifies the maximum desired number of
        /// pods the job should run at any given time. The actual number of
        /// pods running in steady state will be less than this number when
        /// ((.spec.completions - .status.successful) &amp;lt;
        /// .spec.parallelism), i.e. when the work left to do is less than max
        /// parallelism. More info: http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        [JsonProperty(PropertyName = "parallelism")]
        public int? Parallelism { get; set; }

        /// <summary>
        /// Gets or sets selector is a label query over pods that should match
        /// the pod count. Normally, the system sets this field for you. More
        /// info: http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public V1LabelSelector Selector { get; set; }

        /// <summary>
        /// Gets or sets template is the object that describes the pod that
        /// will be created when executing a job. More info:
        /// http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public V1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (Template != null)
            {
                Template.Validate();
            }
        }
    }
}
