using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ISupplierInvoiceFileConnectionConnector : IConnector
	{
		Sort.Order? SortOrder { get; set; }
		Sort.By.SupplierInvoiceFileConnection? SortBy { get; set; }

        [SearchParameter("filter")]
		Filter.SupplierInvoiceFileConnection? FilterBy { get; set; }

        [SearchParameter]
		string SupplierInvoiceNumber { get; set; }

        SupplierInvoiceFileConnection Create(SupplierInvoiceFileConnection supplierInvoiceFileConnection);

		SupplierInvoiceFileConnection Get(string id);

		void Delete(string id);

		EntityCollection<SupplierInvoiceFileConnection> Find();

	}
}