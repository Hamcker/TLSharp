using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPageBlockTypes
	{
		TLPageBlockUnsupported,TLPageBlockTitle,TLPageBlockSubtitle,TLPageBlockAuthorDate,TLPageBlockHeader,TLPageBlockSubheader,TLPageBlockParagraph,TLPageBlockPreformatted,TLPageBlockFooter,TLPageBlockDivider,TLPageBlockAnchor,TLPageBlockList,TLPageBlockBlockquote,TLPageBlockPullquote,TLPageBlockPhoto,TLPageBlockVideo,TLPageBlockCover,TLPageBlockEmbed,TLPageBlockEmbedPost,TLPageBlockCollage,TLPageBlockSlideshow
	}

    public abstract class TLAbsPageBlock : TLObject
    {
		public TLAbsPageBlockTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPageBlock
        {
            return this as T;
        }

		public TLPageBlockUnsupported ToTLPageBlockUnsupported()
		{
			return this as TLPageBlockUnsupported;
		}

		public TLPageBlockTitle ToTLPageBlockTitle()
		{
			return this as TLPageBlockTitle;
		}

		public TLPageBlockSubtitle ToTLPageBlockSubtitle()
		{
			return this as TLPageBlockSubtitle;
		}

		public TLPageBlockAuthorDate ToTLPageBlockAuthorDate()
		{
			return this as TLPageBlockAuthorDate;
		}

		public TLPageBlockHeader ToTLPageBlockHeader()
		{
			return this as TLPageBlockHeader;
		}

		public TLPageBlockSubheader ToTLPageBlockSubheader()
		{
			return this as TLPageBlockSubheader;
		}

		public TLPageBlockParagraph ToTLPageBlockParagraph()
		{
			return this as TLPageBlockParagraph;
		}

		public TLPageBlockPreformatted ToTLPageBlockPreformatted()
		{
			return this as TLPageBlockPreformatted;
		}

		public TLPageBlockFooter ToTLPageBlockFooter()
		{
			return this as TLPageBlockFooter;
		}

		public TLPageBlockDivider ToTLPageBlockDivider()
		{
			return this as TLPageBlockDivider;
		}

		public TLPageBlockAnchor ToTLPageBlockAnchor()
		{
			return this as TLPageBlockAnchor;
		}

		public TLPageBlockList ToTLPageBlockList()
		{
			return this as TLPageBlockList;
		}

		public TLPageBlockBlockquote ToTLPageBlockBlockquote()
		{
			return this as TLPageBlockBlockquote;
		}

		public TLPageBlockPullquote ToTLPageBlockPullquote()
		{
			return this as TLPageBlockPullquote;
		}

		public TLPageBlockPhoto ToTLPageBlockPhoto()
		{
			return this as TLPageBlockPhoto;
		}

		public TLPageBlockVideo ToTLPageBlockVideo()
		{
			return this as TLPageBlockVideo;
		}

		public TLPageBlockCover ToTLPageBlockCover()
		{
			return this as TLPageBlockCover;
		}

		public TLPageBlockEmbed ToTLPageBlockEmbed()
		{
			return this as TLPageBlockEmbed;
		}

		public TLPageBlockEmbedPost ToTLPageBlockEmbedPost()
		{
			return this as TLPageBlockEmbedPost;
		}

		public TLPageBlockCollage ToTLPageBlockCollage()
		{
			return this as TLPageBlockCollage;
		}

		public TLPageBlockSlideshow ToTLPageBlockSlideshow()
		{
			return this as TLPageBlockSlideshow;
		}

    }
}
