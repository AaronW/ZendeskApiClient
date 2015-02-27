using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ZendeskApi.Contracts.Models
{
    [Description("Request")]
    [DataContract]
    public class Request : IZendeskEntity
    {
        [DataMember(EmitDefaultValue = false)]
        public long? Id { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "due_at", EmitDefaultValue = false)]
        public DateTime? Due { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TicketType? Type { get; set; }   // TODO change this to RequestType?

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "requester_id", EmitDefaultValue = false)]
        public long? RequesterId { get; set; }

        [DataMember(Name = "assignee_id", EmitDefaultValue = false)]
        public long? AssigneeId { get; set; }

        [DataMember(Name = "organization_id", EmitDefaultValue = false)]
        public long? OrganisationId { get; set; }

        [DataMember(EmitDefaultValue = false)]  // TODO needs mapped to "url"?
        public Uri Url { get; set; }

        [DataMember(EmitDefaultValue = false)]  // TODO needs mapped to "priority"?
        public string Priority { get; set; }

        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public int? GroupId { get; set; }

        [DataMember(Name = "ticket_form_id", EmitDefaultValue = false)]
        public int? FormId { get; set; }

        [DataMember(Name = "via")]
        public Via Via { get; set; }

        [DataMember(Name = "custom_fields")]
        public List<CustomField> CustomFields { get; private set; }

        // ReSharper disable InconsistentNaming
        [IgnoreDataMember]
        public List<long> collaborator_ids { get; set; }
        // ReSharper restore InconsistentNaming
    }
}
