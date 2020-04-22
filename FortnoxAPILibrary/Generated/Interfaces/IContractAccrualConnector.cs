using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IContractAccrualConnector : IConnector
	{
		Sort.Order? SortOrder { get; set; }
		Sort.By.ContractAccrual? SortBy { get; set; }

        [SearchParameter("filter")]
		Filter.ContractAccrual? FilterBy { get; set; }

		ContractAccrual Update(ContractAccrual contractAccrual);

		ContractAccrual Create(ContractAccrual contractAccrual);

		ContractAccrual Get(int? id);

		void Delete(int? id);

		EntityCollection<ContractAccrualSubset> Find();

	}
}