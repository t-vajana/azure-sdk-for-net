// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes all the properties of a JobOutput.
    /// </summary>
    public partial class JobOutput
    {
        /// <summary>
        /// Initializes a new instance of the JobOutput class.
        /// </summary>
        public JobOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobOutput class.
        /// </summary>
        /// <param name="error">If the JobOutput is in the Error state, it
        /// contains the details of the error.</param>
        /// <param name="state">Describes the state of the JobOutput. Possible
        /// values include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="progress">If the JobOutput is in a Processing state,
        /// this contains the Job completion percentage. The value is an
        /// estimate and not intended to be used to predict Job completion
        /// times. To determine if the JobOutput is complete, use the State
        /// property.</param>
        /// <param name="label">A label that is assigned to a JobOutput in
        /// order to help uniquely identify it. This is useful when your
        /// Transform has more than one TransformOutput, whereby your Job has
        /// more than one JobOutput. In such cases, when you submit the Job,
        /// you will add two or more JobOutputs, in the same order as
        /// TransformOutputs in the Transform. Subsequently, when you retrieve
        /// the Job, either through events or on a GET request, you can use the
        /// label to easily identify the JobOutput. If a label is not provided,
        /// a default value of '{presetName}_{outputIndex}' will be used, where
        /// the preset name is the name of the preset in the corresponding
        /// TransformOutput and the output index is the relative index of the
        /// this JobOutput within the Job. Note that this index is the same as
        /// the relative index of the corresponding TransformOutput within its
        /// Transform.</param>
        public JobOutput(JobError error = default(JobError), JobState state = default(JobState), int progress = default(int), string label = default(string))
        {
            Error = error;
            State = state;
            Progress = progress;
            Label = label;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets if the JobOutput is in the Error state, it contains the
        /// details of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public JobError Error { get; private set; }

        /// <summary>
        /// Gets describes the state of the JobOutput. Possible values include:
        /// 'Canceled', 'Canceling', 'Error', 'Finished', 'Processing',
        /// 'Queued', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState State { get; private set; }

        /// <summary>
        /// Gets if the JobOutput is in a Processing state, this contains the
        /// Job completion percentage. The value is an estimate and not
        /// intended to be used to predict Job completion times. To determine
        /// if the JobOutput is complete, use the State property.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int Progress { get; private set; }

        /// <summary>
        /// Gets or sets a label that is assigned to a JobOutput in order to
        /// help uniquely identify it. This is useful when your Transform has
        /// more than one TransformOutput, whereby your Job has more than one
        /// JobOutput. In such cases, when you submit the Job, you will add two
        /// or more JobOutputs, in the same order as TransformOutputs in the
        /// Transform. Subsequently, when you retrieve the Job, either through
        /// events or on a GET request, you can use the label to easily
        /// identify the JobOutput. If a label is not provided, a default value
        /// of '{presetName}_{outputIndex}' will be used, where the preset name
        /// is the name of the preset in the corresponding TransformOutput and
        /// the output index is the relative index of the this JobOutput within
        /// the Job. Note that this index is the same as the relative index of
        /// the corresponding TransformOutput within its Transform.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

    }
}