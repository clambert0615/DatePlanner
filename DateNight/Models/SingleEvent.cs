﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateNight.Models
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName ="event", IsNullable = false)]
    public partial class Event
    {

        private string urlField;

        private string titleField;

        private object descriptionField;

        private string start_timeField;

        private object stop_timeField;

        private byte all_dayField;

        private object tz_idField;

        private object tz_olson_pathField;

        private string olson_pathField;

        private object tz_countryField;

        private object tz_cityField;

        private string venue_nameField;

        private string venue_idField;

        private string venue_typeField;

        private byte venue_displayField;

        private string addressField;

        private string cityField;

        private string regionField;

        private string region_abbrField;

        private ushort postal_codeField;

        private string countryField;

        private string country_abbr2Field;

        private string country_abbrField;

        private decimal latitudeField;

        private decimal longitudeField;

        private string geocode_typeField;

        private string createdField;

        private string modifiedField;

        private string ownerField;

        private byte privacyField;

        private object freeField;

        private object priceField;

        private byte withdrawnField;

        private object withdrawn_noteField;

        private object recurrenceField;

        private object parentsField;

        private object childrenField;

        private object linksField;

        private object commentsField;

        private object trackbacksField;

        private eventPerformers performersField;

        private eventImage[] imagesField;

        private eventTag[] tagsField;

        private object calendarsField;

        private object groupsField;

        private object goingField;

        private object propertiesField;

        private eventCategories categoriesField;

        private string idField;

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return (string)this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string start_time
        {
            get
            {
                return this.start_timeField;
            }
            set
            {
                this.start_timeField = value;
            }
        }

        /// <remarks/>
        public object stop_time
        {
            get
            {
                return this.stop_timeField;
            }
            set
            {
                this.stop_timeField = value;
            }
        }

        /// <remarks/>
        public byte all_day
        {
            get
            {
                return this.all_dayField;
            }
            set
            {
                this.all_dayField = value;
            }
        }

        /// <remarks/>
        public object tz_id
        {
            get
            {
                return this.tz_idField;
            }
            set
            {
                this.tz_idField = value;
            }
        }

        /// <remarks/>
        public object tz_olson_path
        {
            get
            {
                return this.tz_olson_pathField;
            }
            set
            {
                this.tz_olson_pathField = value;
            }
        }

        /// <remarks/>
        public string olson_path
        {
            get
            {
                return this.olson_pathField;
            }
            set
            {
                this.olson_pathField = value;
            }
        }

        /// <remarks/>
        public object tz_country
        {
            get
            {
                return this.tz_countryField;
            }
            set
            {
                this.tz_countryField = value;
            }
        }

        /// <remarks/>
        public object tz_city
        {
            get
            {
                return this.tz_cityField;
            }
            set
            {
                this.tz_cityField = value;
            }
        }

        /// <remarks/>
        public string venue_name
        {
            get
            {
                return this.venue_nameField;
            }
            set
            {
                this.venue_nameField = value;
            }
        }

        /// <remarks/>
        public string venue_id
        {
            get
            {
                return this.venue_idField;
            }
            set
            {
                this.venue_idField = value;
            }
        }

        /// <remarks/>
        public string venue_type
        {
            get
            {
                return this.venue_typeField;
            }
            set
            {
                this.venue_typeField = value;
            }
        }

        /// <remarks/>
        public byte venue_display
        {
            get
            {
                return this.venue_displayField;
            }
            set
            {
                this.venue_displayField = value;
            }
        }

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string region_abbr
        {
            get
            {
                return this.region_abbrField;
            }
            set
            {
                this.region_abbrField = value;
            }
        }

        /// <remarks/>
        public ushort postal_code
        {
            get
            {
                return this.postal_codeField;
            }
            set
            {
                this.postal_codeField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string country_abbr2
        {
            get
            {
                return this.country_abbr2Field;
            }
            set
            {
                this.country_abbr2Field = value;
            }
        }

        /// <remarks/>
        public string country_abbr
        {
            get
            {
                return this.country_abbrField;
            }
            set
            {
                this.country_abbrField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public string geocode_type
        {
            get
            {
                return this.geocode_typeField;
            }
            set
            {
                this.geocode_typeField = value;
            }
        }

        /// <remarks/>
        public string created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        public string modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        public string owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public byte privacy
        {
            get
            {
                return this.privacyField;
            }
            set
            {
                this.privacyField = value;
            }
        }

        /// <remarks/>
        public object free
        {
            get
            {
                return this.freeField;
            }
            set
            {
                this.freeField = value;
            }
        }

        /// <remarks/>
        public object price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public byte withdrawn
        {
            get
            {
                return this.withdrawnField;
            }
            set
            {
                this.withdrawnField = value;
            }
        }

        /// <remarks/>
        public object withdrawn_note
        {
            get
            {
                return this.withdrawn_noteField;
            }
            set
            {
                this.withdrawn_noteField = value;
            }
        }

        /// <remarks/>
        public object recurrence
        {
            get
            {
                return this.recurrenceField;
            }
            set
            {
                this.recurrenceField = value;
            }
        }

        /// <remarks/>
        public object parents
        {
            get
            {
                return this.parentsField;
            }
            set
            {
                this.parentsField = value;
            }
        }

        /// <remarks/>
        public object children
        {
            get
            {
                return this.childrenField;
            }
            set
            {
                this.childrenField = value;
            }
        }

        /// <remarks/>
        public object links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }

        /// <remarks/>
        public object comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public object trackbacks
        {
            get
            {
                return this.trackbacksField;
            }
            set
            {
                this.trackbacksField = value;
            }
        }

        /// <remarks/>
        public eventPerformers performers
        {
            get
            {
                return this.performersField;
            }
            set
            {
                this.performersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public eventImage[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("tag", IsNullable = false)]
        public eventTag[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public object calendars
        {
            get
            {
                return this.calendarsField;
            }
            set
            {
                this.calendarsField = value;
            }
        }

        /// <remarks/>
        public object groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
            }
        }

        /// <remarks/>
        public object going
        {
            get
            {
                return this.goingField;
            }
            set
            {
                this.goingField = value;
            }
        }

        /// <remarks/>
        public object properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public eventCategories categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventPerformers
    {

        private eventPerformersPerformer performerField;

        /// <remarks/>
        public eventPerformersPerformer performer
        {
            get
            {
                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventPerformersPerformer
    {

        private string idField;

        private string urlField;

        private string nameField;

        private string short_bioField;

        private string creatorField;

        private string linkerField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string short_bio
        {
            get
            {
                return this.short_bioField;
            }
            set
            {
                this.short_bioField = value;
            }
        }

        /// <remarks/>
        public string creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        public string linker
        {
            get
            {
                return this.linkerField;
            }
            set
            {
                this.linkerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventImage
    {

        private string idField;

        private string creatorField;

        private string urlField;

        private byte widthField;

        private byte heightField;

        private eventImageThumb thumbField;

        private eventImageSmall smallField;

        private eventImageMedium mediumField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public eventImageThumb thumb
        {
            get
            {
                return this.thumbField;
            }
            set
            {
                this.thumbField = value;
            }
        }

        /// <remarks/>
        public eventImageSmall small
        {
            get
            {
                return this.smallField;
            }
            set
            {
                this.smallField = value;
            }
        }

        /// <remarks/>
        public eventImageMedium medium
        {
            get
            {
                return this.mediumField;
            }
            set
            {
                this.mediumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventImageThumb
    {

        private string urlField;

        private byte widthField;

        private byte heightField;

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventImageSmall
    {

        private string urlField;

        private byte widthField;

        private byte heightField;

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventImageMedium
    {

        private string urlField;

        private byte widthField;

        private byte heightField;

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventTag
    {

        private string titleField;

        private string ownerField;

        private string idField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventCategories
    {

        private eventCategoriesCategory categoryField;

        /// <remarks/>
        public eventCategoriesCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eventCategoriesCategory
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }




}
