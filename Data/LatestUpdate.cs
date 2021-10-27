using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relizealous.Data
{
	public class LatestUpdate
	{

		public string Title { get; set; }

		public string Description { get; set; }

		public string DefaultLink { get; set; }

        public string LangLink { get; set; }

        public string AudioLink { get; set; }

        public static readonly LatestUpdate[] Collection
        = new LatestUpdate[]
		{

			new LatestUpdate { 
				Title="June 29, 2021", 
				Description="Divya Prabandham Pottrum Tirukkudandai, a collection of pasurams from 4000 Divya Prabandham dedicated to Lord Srii Shaargapaanii Perumaal.",
				DefaultLink="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
				LangLink="hayagriivakavacham1.pdf",
				AudioLink = "/sounds/dwayne.mp3"
				 },
			new LatestUpdate
			{
				Title="June 28, 2021",
				Description="Srii Gadaadharastotram from Srii Vamana Puranam composed by Raibhya.",
				DefaultLink="/Contents/slokas/Tamil/gadaadharastotram.pdf",
				LangLink="hayagriivakavacham1.pdf",
				AudioLink = "/sounds/duh.mp3"
			}


};

	}

	public class LatestUpdateRepository
	{

		private static readonly LatestUpdate[] Collection = new LatestUpdate[] {

			new LatestUpdate 
			{
				Title="June 29, 2021",
				Description="Divya Prabandham Pottrum Tirukkudandai, a collection of pasurams from 4000 Divya Prabandham dedicated to Lord Srii Shaargapaanii Perumaal.",
				DefaultLink="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
				LangLink=""
			},
			new LatestUpdate
			{
				Title="June 28, 2021",
				Description="Srii Gadaadharastotram from Srii Vamana Puranam composed by Raibhya.",
				DefaultLink="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
				LangLink=""
			}

		};

		public IEnumerable<LatestUpdate> Get()
		{
			return Collection;
		}

	}
}
