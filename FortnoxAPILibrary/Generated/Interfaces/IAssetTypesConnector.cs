using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IAssetTypesConnector : IConnector
	{
		Sort.Order? SortOrder { get; set; }
		Sort.By.AssetTypes? SortBy { get; set; }

        [SearchParameter("filter")]
		Filter.AssetTypes? FilterBy { get; set; }

		AssetType Update(AssetType assetType);

		AssetType Create(AssetType assetType);

		AssetType Get(int? id);

		void Delete(int? id);

		EntityCollection<AssetTypesSubset> Find();

	}
}