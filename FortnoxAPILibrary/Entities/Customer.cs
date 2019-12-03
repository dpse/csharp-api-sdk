﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.ComponentModel;
using System;
using FortnoxAPILibrary.Connectors;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Customer
	{
		private string activeField;

		private string address1Field;

		private string address2Field;

		private string cityField;

		private string countryField;

		private string commentsField;

		private string currencyField;

		private string costCenterField;

		private string countryCodeField;

		private string customerNumberField;

		private InvoiceDefaultDeliveryTypes defaultDeliveryTypesField;

		private InvoiceDefaultTemplates defaultTemplatesField;

		private string deliveryAddress1Field;

		private string deliveryAddress2Field;

		private string deliveryCityField;

		private string deliveryCountryField;

		private string deliveryCountryCodeField;

		private string deliveryFaxField;

		private string deliveryNameField;

		private string deliveryPhone1Field;

		private string deliveryPhone2Field;

		private string deliveryZipCodeField;

		private string emailField;

		private string emailInvoiceField;

		private string emailInvoiceBCCField;

		private string emailInvoiceCCField;

		private string emailOfferField;

		private string emailOfferBCCField;

		private string emailOfferCCField;

		private string emailOrderField;

		private string emailOrderBCCField;

		private string emailOrderCCField;

		private string faxField;

		private string glnField;

		private string glnDeliveryField;

		private string invoiceAdministrationFeeField;

		private string invoiceDiscountField;

		private string invoiceFreightField;

		private string invoiceRemarkField;

		private string nameField;

		private string organisationNumberField;

		private string ourReferenceField;

		private string phone1Field;

		private string phone2Field;

		private string priceListField;

		private string projectField;

		private string salesAccountField;

		private string showPriceVatIncludedField;

		private string termsOfDeliveryField;

		private string termsOfPaymentField;

		private CustomerConnector.Type? typeField;

		private string vATNumberField;

		private CustomerConnector.VATType? vATTypeField;

		private string visitingAddressField;

		private string visitingCityField;

        private string visitingCountryField;

        private string visitingCountryCodeField;

		private string visitingZipCodeField;

		private string wayOfDeliveryField;

		private string yourReferenceField;

		private string zipCodeField;

		private string urlField;

		/// <remarks/>
		public string Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
			}
		}

		/// <remarks/>
		public string Address1
		{
			get
			{
				return this.address1Field;
			}
			set
			{
				this.address1Field = value;
			}
		}

		/// <remarks/>
		public string Address2
		{
			get
			{
				return this.address2Field;
			}
			set
			{
				this.address2Field = value;
			}
		}

		/// <remarks/>
		public string City
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

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly(true)]
		public string Country
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
		public string Comments
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
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}

		/// <remarks/>
		public string CostCenter
		{
			get
			{
				return this.costCenterField;
			}
			set
			{
				this.costCenterField = value;
			}
		}

		/// <remarks/>
		public string CountryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}

		/// <remarks/>
		public string CustomerNumber
		{
			get
			{
				return this.customerNumberField;
			}
			set
			{
				this.customerNumberField = value;
			}
		}

		/// <remarks/>
		public InvoiceDefaultDeliveryTypes DefaultDeliveryTypes
		{
			get
			{
				return this.defaultDeliveryTypesField;
			}
			set
			{
				this.defaultDeliveryTypesField = value;
			}
		}

		/// <remarks/>
		public InvoiceDefaultTemplates DefaultTemplates
		{
			get
			{
				return this.defaultTemplatesField;
			}
			set
			{
				this.defaultTemplatesField = value;
			}
		}

		/// <remarks/>
		public string DeliveryAddress1
		{
			get
			{
				return this.deliveryAddress1Field;
			}
			set
			{
				this.deliveryAddress1Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryAddress2
		{
			get
			{
				return this.deliveryAddress2Field;
			}
			set
			{
				this.deliveryAddress2Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryCity
		{
			get
			{
				return this.deliveryCityField;
			}
			set
			{
				this.deliveryCityField = value;
			}
		}

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly(true)]
		public string DeliveryCountry
		{
			get
			{
				return this.deliveryCountryField;
			}
			set
			{
				this.deliveryCountryField = value;
			}
		}

		/// <remarks/>
		public string DeliveryCountryCode
		{
			get
			{
				return this.deliveryCountryCodeField;
			}
			set
			{
				this.deliveryCountryCodeField = value;
			}
		}

		/// <remarks/>
		public string DeliveryFax
		{
			get
			{
				return this.deliveryFaxField;
			}
			set
			{
				this.deliveryFaxField = value;
			}
		}

		/// <remarks/>
		public string DeliveryName
		{
			get
			{
				return this.deliveryNameField;
			}
			set
			{
				this.deliveryNameField = value;
			}
		}

		/// <remarks/>
		public string DeliveryPhone1
		{
			get
			{
				return this.deliveryPhone1Field;
			}
			set
			{
				this.deliveryPhone1Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryPhone2
		{
			get
			{
				return this.deliveryPhone2Field;
			}
			set
			{
				this.deliveryPhone2Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryZipCode
		{
			get
			{
				return this.deliveryZipCodeField;
			}
			set
			{
				this.deliveryZipCodeField = value;
			}
		}

		/// <remarks/>
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}

		/// <remarks/>
		public string EmailInvoice
		{
			get
			{
				return this.emailInvoiceField;
			}
			set
			{
				this.emailInvoiceField = value;
			}
		}

		/// <remarks/>
		public string EmailInvoiceBCC
		{
			get
			{
				return this.emailInvoiceBCCField;
			}
			set
			{
				this.emailInvoiceBCCField = value;
			}
		}

		/// <remarks/>
		public string EmailInvoiceCC
		{
			get
			{
				return this.emailInvoiceCCField;
			}
			set
			{
				this.emailInvoiceCCField = value;
			}
		}

		/// <remarks/>
		public string EmailOffer
		{
			get
			{
				return this.emailOfferField;
			}
			set
			{
				this.emailOfferField = value;
			}
		}

		/// <remarks/>
		public string EmailOfferBCC
		{
			get
			{
				return this.emailOfferBCCField;
			}
			set
			{
				this.emailOfferBCCField = value;
			}
		}

		/// <remarks/>
		public string EmailOfferCC
		{
			get
			{
				return this.emailOfferCCField;
			}
			set
			{
				this.emailOfferCCField = value;
			}
		}

		/// <remarks/>
		public string EmailOrder
		{
			get
			{
				return this.emailOrderField;
			}
			set
			{
				this.emailOrderField = value;
			}
		}

		/// <remarks/>
		public string EmailOrderBCC
		{
			get
			{
				return this.emailOrderBCCField;
			}
			set
			{
				this.emailOrderBCCField = value;
			}
		}

		/// <remarks/>
		public string EmailOrderCC
		{
			get
			{
				return this.emailOrderCCField;
			}
			set
			{
				this.emailOrderCCField = value;
			}
		}

		/// <remarks/>
		public string Fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}

		/// <remarks/>
		public string GLN
		{
			get
			{
				return this.glnField;
			}
			set
			{
				this.glnField = value;
			}
		}

		/// <remarks/>
		public string GLNDelivery
		{
			get
			{
				return this.glnDeliveryField;
			}
			set
			{
				this.glnDeliveryField = value;
			}
		}

		/// <remarks/>
		public string InvoiceAdministrationFee
		{
			get
			{
				return this.invoiceAdministrationFeeField;
			}
			set
			{
				this.invoiceAdministrationFeeField = value;
			}
		}

		/// <remarks/>
		public string InvoiceDiscount
		{
			get
			{
				return this.invoiceDiscountField;
			}
			set
			{
				this.invoiceDiscountField = value;
			}
		}

		/// <remarks/>
		public string InvoiceFreight
		{
			get
			{
				return this.invoiceFreightField;
			}
			set
			{
				this.invoiceFreightField = value;
			}
		}

		/// <remarks/>
		public string InvoiceRemark
		{
			get
			{
				return this.invoiceRemarkField;
			}
			set
			{
				this.invoiceRemarkField = value;
			}
		}

		/// <remarks/>
		public string Name
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
		public string OrganisationNumber
		{
			get
			{
				return this.organisationNumberField;
			}
			set
			{
				this.organisationNumberField = value;
			}
		}

		/// <remarks/>
		public string OurReference
		{
			get
			{
				return this.ourReferenceField;
			}
			set
			{
				this.ourReferenceField = value;
			}
		}

		/// <remarks/>
		public string Phone1
		{
			get
			{
				return this.phone1Field;
			}
			set
			{
				this.phone1Field = value;
			}
		}

		/// <remarks/>
		public string Phone2
		{
			get
			{
				return this.phone2Field;
			}
			set
			{
				this.phone2Field = value;
			}
		}

		/// <remarks/>
		public string PriceList
		{
			get
			{
				return this.priceListField;
			}
			set
			{
				this.priceListField = value;
			}
		}

		/// <remarks/>
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}

		/// <remarks/>
		public string SalesAccount
		{
			get
			{
				return this.salesAccountField;
			}
			set
			{
				this.salesAccountField = value;
			}
		}

		/// <remarks/>
		public string ShowPriceVATIncluded
		{
			get
			{
				return this.showPriceVatIncludedField;
			}
			set
			{
				this.showPriceVatIncludedField = value;
			}
		}

		/// <remarks/>
		public string TermsOfDelivery
		{
			get
			{
				return this.termsOfDeliveryField;
			}
			set
			{
				this.termsOfDeliveryField = value;
			}
		}

		/// <remarks/>
		public string TermsOfPayment
		{
			get
			{
				return this.termsOfPaymentField;
			}
			set
			{
				this.termsOfPaymentField = value;
			}
		}

        /// <remarks/>
        public CustomerConnector.Type? Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
        public bool TypeSpecified => this.Type != null;

		/// <remarks/>
		public string VATNumber
		{
			get
			{
				return this.vATNumberField;
			}
			set
			{
				this.vATNumberField = value;
			}
		}

		/// <remarks/>
		public CustomerConnector.VATType? VATType
		{
			get
			{
				return this.vATTypeField;
			}
			set
			{
				this.vATTypeField = value;
			}
		}
        public bool VATTypeSpecified => VATType != null;

        /// <remarks/>
        public string VisitingAddress
		{
			get
			{
				return this.visitingAddressField;
			}
			set
			{
				this.visitingAddressField = value;
			}
		}

		/// <remarks/>
		public string VisitingCity
		{
			get
			{
				return this.visitingCityField;
			}
			set
			{
				this.visitingCityField = value;
			}
		}

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly(true)]
		public string VisitingCountry
		{
			get
			{
				return this.visitingCountryField;
			}
			set
			{
				this.visitingCountryField = value;
			}
		}

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly(true)]
        public string VisitingCountryCode
        {
            get
            {
                return this.visitingCountryCodeField;
            }
            set
            {
                this.visitingCountryCodeField = value;
            }
        }

		/// <remarks/>
		public string VisitingZipCode
		{
			get
			{
				return this.visitingZipCodeField;
			}
			set
			{
				this.visitingZipCodeField = value;
			}
		}

		/// <remarks/>
		public string WayOfDelivery
		{
			get
			{
				return this.wayOfDeliveryField;
			}
			set
			{
				this.wayOfDeliveryField = value;
			}
		}


        /// <remarks/>
        public string WWW { get; set; }


		/// <remarks/>
		public string YourReference
		{
			get
			{
				return this.yourReferenceField;
			}
			set
			{
				this.yourReferenceField = value;
			}
		}

		/// <remarks/>
		public string ZipCode
		{
			get
			{
				return this.zipCodeField;
			}
			set
			{
				this.zipCodeField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly(true)]
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class InvoiceDefaultDeliveryTypes
	{

		private CustomerConnector.DefaultInvoiceDeliveryType? invoiceField;

		private CustomerConnector.DefaultOfferDeliveryType? offerField;

		private CustomerConnector.DefaultOrderDeliveryType? orderField;

		/// <remarks/>
		public CustomerConnector.DefaultInvoiceDeliveryType? Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
        }
        public bool InvoiceSpecified => Invoice != null;

        /// <remarks/>
        public CustomerConnector.DefaultOfferDeliveryType? Offer
		{
			get
			{
				return this.offerField;
			}
			set
			{
				this.offerField = value;
			}
		}
        public bool OfferSpecified => Offer != null;

        /// <remarks/>
        public CustomerConnector.DefaultOrderDeliveryType? Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}
        public bool OrderSpecified => Order != null;
    }

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class InvoiceDefaultTemplates
	{

		private string cashInvoiceField;

		private string invoiceField;

		private string offerField;

		private string orderField;

		/// <remarks/>
		public string CashInvoice
		{
			get
			{
				return this.cashInvoiceField;
			}
			set
			{
				this.cashInvoiceField = value;
			}
		}

		/// <remarks/>
		public string Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}

		/// <remarks/>
		public string Offer
		{
			get
			{
				return this.offerField;
			}
			set
			{
				this.offerField = value;
			}
		}

		/// <remarks/>
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}
	}

}