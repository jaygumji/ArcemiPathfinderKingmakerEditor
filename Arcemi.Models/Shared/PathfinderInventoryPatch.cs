﻿using System;
using System.Collections.Generic;

namespace Arcemi.Models.Shared
{
    public static class PathfinderInventoryPatch
    {
        private static readonly HashSet<string> NaturalWeapons = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
            "cb3d56dab7e5c17468707da5950a4a01", "614a4965a7c28af4583d915e32122efd", "02ddd90708153994d87f422abe87f45d", "57c209957fd95fe4c8ef830e8187b4f4",
            "efe700e7e536e7942bccd585b49e8861", "d9710d020ee29764aabda3e37b3c6293", "2f4eced2e3d978345a92685bcde4551e", "d889d3f8edd9ee54a9623c8127b0546f",
            "67aefd7e9d30cb840aed6fb9d64fee83", "61fb13235c614f744ad42ff6141fab0e", "aff1d5d4884d4267a4b0abe82c917204", "c47ddfd181931764aa508b7b5aa27710",
            "8775e3bef5425214da9cd20bdf1c255b", "27eee74857c42db499b3a6b20cfa6211", "24ed0b84ca2daa54b944b1633c1e4f35", "04499d551301bf9488c1e94b74f8c6d2",
            "a3ef31b3ccfeb2f44a33e45cd9e1ba44", "f85787ca8748bda45ba264b2ceea8633", "2dd160bed2cf42dbb4a11294f2c3460f", "6908ae4e0754cf04684ab7a9e245c917",
            "9c20ebc9f7b701743944b1c76d4bf598", "d2f99947db522e24293a7ec4eded453f", "54af541fa85b3634cb6b801d96c3f2c9", "a63315767e2bfe841959644dbe6383dc",
            "8e4310cc393d8da438b8781269417819", "f48bb2b51b9e10347aa22208d97220b2", "a3ad00b4377928244b18c31e9f604335", "96cb163919afd3445a4b863c677f95a1",
            "75254f19ca6e1d048a88b7545bb65221", "a12e827ed5bcc6840899a58b6e0f3195", "38830cb6bcd04225b93af2c1d3d689a4", "a126e4a78353d2240a18cfa3c1185947",
            "2d7f156fed971b2498ec8a191ce69932", "1ce94db22f68fe843b3b75cb3bd7410a", "eacc032340e92fe48b55f65faa886113", "340ab07dff974a841b76f22ba4c3cf84",
            "9ad2424212f72054e81bfdd8b0e7a29e", "6df32bb8dafc7ae45a61a05284a0d847", "18e78d9385784f34cb472c1054861aa6", "73df286e1ff6f8a40a5b0e9555d79b5b",
            "c36359e00abf82b40b5df9e5394207dd", "6df5d8e60f786734e9bd229ec3c9f348", "9852a7085c178df4db196fa0b3f05164", "78984ad70667084469ca7587465d4609",
            "c988aa874d11ff84d873508ddc9b928f", "bd01663d66d041ef9867b657952e699f", "ec35ef997ed5a984280e1a6d87ae80a8", "48647a4517e6512419e937f7a617ea5c",
            "91e6ea765d3d94e4babfca70a8df4556", "c76f72a862d168d44838206524366e1c", "bef6f133e728bd74ab871e1f2072e726", "8afc47748d00b3e4a8aff2787d9ee350",
            "52b49a48d7b25814581953b3f2bff01c", "36592d497f094c26ba796203c842f2ad", "07a9a02123c00064f8742d9253ddb742", "73ed4e955295e62469fe471f1d49d9ef",
            "d1f80b5c5c73cc84db7854774850b08c", "4b68c767d19e7cb418ffbbf5eb6a0f92", "15bb40b3d07d6d0488a6b1a11a809e3a", "6d3929aee934c444e983f99c361a8807",
            "7fe0fa95a5c21ee439e6849b7e018a82", "dface6653c3c491d90fe193e3da6f26d", "5ed9cc5be301fae44b24824074edea0f", "63d4efcd1d5cafe43a60325f304978ca",
            "3d33a0f6c3eea8d4aab3e18ad983bff7", "6536b4f74a4a3c04fabcc4fb34f061ad", "ae822725634c6f0418b8c48bd29df255", "974cd04756f70a34da2d0905ac48d25c",
            "edd98b7f1acb2c64284715b80ea489e3", "f1837302691341b88e309c639bcf5797", "b0b2d13e528c4d438d00007401ce9955", "fdcd4c515f7e4564b193d589e4741977",
            "3f2008c722798014c95f1498ec85e1f7", "06c210c77c30a36478cb8dbf225fb364", "d53e7995a3ea3f646af020d1b9b56d68", "cc86ff4cd9bf7ff45863c19f7f0cb11f",
            "085547b82eded104ba7e1870dd0563bf", "7426682fa2e773a49a80d69e3d58d1dc", "8c578b108b90be9408e5fd136c9cb041", "35dfad6517f401145af54111be04d6cf",
            "8e644203e127404eb816170145d7cf08", "a000716f88c969c499a535dadcf09286", "61bc14eca5f8c1040900215000cfc218", "a03ed20c09b710e4fa60324ddb0c9b5f",
            "2abc1dc6172759c42971bd04b8c115cb", "07e2c405025d5074abfff20e2c34f9ba", "c0f17a316468464d91142c01e489f106", "06e1cd5de4274553ae2cbcddc8b21a36",
            "f3ff6972c32f22e4ba4c85c3982a03cf", "32c919bb471d7c549871258d905d33ee", "62c479a65a03318408cd425121f83b9d", "800092a2b9a743b48ae8aeeb5d243dcc",
            "118fdd03e569a66459ab01a20af6811a", "65eb73689b94d894080d33a768cdf645", "09f0a7c4409ab3e49ab66e1963539f1a", "13a4ac62fe603fc4c99f9ed5e5d0b9d6",
            "d498b2af675bd3447a0ab65ccc34d952", "bd440fff6bfc3954aac8b6e59a9d7489", "daf4ab765feba8548b244e174e7af5be", "ae5e3d5387ce46c2979ff067cfdef74f",
            "6ab25dacc0c959049898de9084a053fc", "76bf1dc3698c4d81a8bed80021dac511", "76ada2578e9121a44b8ffbb7c1f2b5f0", "5d7d23f5e35254d4bb087f7476163509",
            "b0e472a49ff2a294f93faa3ab757a4a5", "92386f3c3cd6b6a4cbe16e25164cd764", "5ec7fd24384d2af4e9afcae17ccdd287", "d8706fda7904db8448258800f0bdc006",
            "7445b0b255796d34495a8bca81b2e2d4", "767e6932882a99c4b8ca95c88d823137", "5ea80d97dcfc81f46a1b9b2f256340f2", "1b327fd5d4ef5b548bf92612939af0cd",
            "c6d3cd958772be148952c011b3a15452", "e3f890217385e3444aff9d36fc7691b8", "9088e563c33748b409bf165dd234fb25", "df44800dbe7b4ba43ac6e0e435041ed8",
            "af0be9fbbda53dc469de6817346f9755", "37c14591cd6aeaf45a358d4e055503d4", "dbc2c3abaef847e2a58a527e1429dc5d", "aa0595c0872d5e049b5a33e63ac36310",
            "c42e22dbdee84d3d9ac8fe06c1e8a54e", "898c1e3fdec34ccebe3702c78a2f20e8", "b21cd5b03fbb0f542815580e66f85915", "29e50b018da8468c8dcb411148ba6413",
            "2051b156321946245b94caf84f4cc686", "808f600afec12b2498f2e48ec2f935d9", "ee31a19c8aa965f46a90ae02d59d4af7", "e5ea5042194712040a3b2944e6944d10",
            "f60c5a820b69fb243a4cce5d1d07d06e", "9e87f72f8069310469d4431e925f035a", "7afc18ecb2cd96541b5cb8395f40d48c", "889e2927a67bd724ea1c203fe1b8b652",
            "84af5e0b4f5f251449aac2b530fab3d0", "864e29d3e07ad4a4f96d576b366b4a86", "cdbf5fdd86eb4d238cef15f7835e42c3", "55fa8806621a4c3408d458090c086cf2",
            "bd4417c15511afe42850fb4d3a6b4a32", "ebb1e708e46d32c4888207913f76e555", "12a8a3a89e62d6b4fbc09ecdc187a828", "952e30e6cb40b454789a9db6e5f6dd09",
            "9b9da970fb869cf469007b51a42f661b", "e47557fbe9084c089b3e25f3908044e5", "3e26b00461ead9a4d8bb1ababaf99f63", "899a905e8b7c4566ab48005d7fce2189",
            "a03f15ead432e584b8542ff25a1b3ac6", "d4f7aee36efe0b54e810c9d3407b6ab3", "8034aa61e74b8ba4fa67c1a4288f45c1", "493243bca1fb64f4dbdc56023fc1b0af",
            "d4efec9dac9a4fbda64cef600e9bcd38", "9a1e014ac86afb0419428cf33752158e", "970df67e0c810174ebf771735e4777e5", "a8b38f6b734daa44087ec0ec2e80c1cd",
            "904e948c3e4c6084e90613bdaf1469c6", "352b738b4ebfd554b909852e7f3b690a", "ad298a0ee3ca1ba419d0c973d1a905f2", "a2779c7d80db9b749816d9c706060178",
            "e302f0fcfeae0aa4f94e65b591b7a893", "7d5254ebdffd64847ac34a9535fc30f1", "f18cbcb39a1b35643a8d129b1ec4e716", "3f8cef2cb180e074d913df6bdbff0270",
            "df73feed59b7d264aa306b3968d00ea5", "591f79febd2d90544b685892ab828191", "17e75cc3be254544b81862b6c98c400b", "b6a50705eb5dfab4fafd577020f49c5e",
            "a9161a18e091d764884ab6434e4ce448", "9c641eb311104a2b89056db7b2c73def", "34c90ab7a0d6e05449f081c122ca219f", "4ce435468ebd4364997da8cbd0c66133",
            "3e26f2e9fc4373c498266aa83e810665", "88291a2a52c7cb04a9a59f51df9880eb", "a4f0141e6df8db04dadccd6b8c1474df", "65d149a76196d4340b7006a6f74ddd7b",
            "e03738c69ae8c914c827e72a3ca91f83", "0ba61ad0eb0f480eb3da3aa4d7bbe37e",
        };

        /// <summary>
        /// Patches a bug in the Pathfinder games where natural weapons is left in the inventory
        /// </summary>
        public static void RemoveNaturalUnequippedWeapons(IGameInventoryModel inventory)
        {
            foreach (var section in inventory.Sections) {
                for (var i = section.Items.Count - 1; i >= 0; i--) {
                    var item = section.Items[i];
                    if (NaturalWeapons.Contains(item.Blueprint)) {
                        section.Items.Remove(item);
                    }
                }
            }
        }
    }
}
