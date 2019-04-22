using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Map
    {
        string Name { get; set; }
        string CharacterClass { get; set; }
        int HitPoints { get; set; }
        int ExperiencePoints { get; set; }
        int Level { get; set; }
        int Gold { get; set; }
    }
    private void OnButtonKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Down:
                if (previousDirection != (int)MOVINGDIRECTION.UPWARDS)
                    direction = (int)MOVINGDIRECTION.DOWNWARDS;
                break;
            case Key.Up:
                if (previousDirection != (int)MOVINGDIRECTION.DOWNWARDS)
                    direction = (int)MOVINGDIRECTION.UPWARDS;
                break;
            case Key.Left:
                if (previousDirection != (int)MOVINGDIRECTION.TORIGHT)
                    direction = (int)MOVINGDIRECTION.TOLEFT;
                break;
            case Key.Right:
                if (previousDirection != (int)MOVINGDIRECTION.TOLEFT)
                    direction = (int)MOVINGDIRECTION.TORIGHT;
                break;
        }
        previousDirection = direction; 

    }
    
        
    
}
