using System.Collections.Generic;

namespace GardenApp
{
    class Garden
    {
        private List<Flowers> flowers;
        private List<Tree> trees;

        public Garden()
        {
            flowers = new List<Flowers>();
            trees = new List<Tree>();
        }

        public void AddFlower(Flowers flower)
        {
            flowers.Add(flower);
        }

        public void AddTree(Tree tree)
        {
            trees.Add(tree);
        }

    }
}
