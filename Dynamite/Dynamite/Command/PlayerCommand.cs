using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamite.Command
{
    public class PlayerCommand: CommandClass
    {
        // Execute new command
        public Player _player;
        private Keys _operator;
        public Keys Operator
        {
            set { _operator = value; }
        }

        public PlayerCommand(Player _player,
      Keys @operator)
        {
            this._player = _player;
            this._operator = @operator;
        }

        public override void Execute()
        {
            char op = '0';
            switch(_operator)
            {
                case Keys.Up:
                    op = 'U';
                    break;
                case Keys.Down:
                    op = 'D';
                    break;
                case Keys.Left:
                    op = 'L';
                    break;
                case Keys.Right:
                    op = 'R';
                    break;
                case Keys.Space:
                    op = 'S';
                    break;
                case Keys.ControlKey:
                    op = 'C';
                    break;
                case Keys.Escape:
                    op = 'E';
                    break;
            }
            _player.Operation(op);
        }

        // Unexecute last command

        public override void UnExecute()
        {
            _player.Operation(Undo(_operator));
        }
        private char Undo(Keys @operator)
        {
            char op = '0';
            switch (_operator)
            {
                case Keys.Up:
                    op = 'D';
                    break;
                case Keys.Down:
                    op = 'U';
                    break;
                case Keys.Left:
                    op = 'R';
                    break;
                case Keys.Right:
                    op = 'L';
                    break;
                   
                case Keys.Space:
                    op = 'C';
                    break;
                   
                case Keys.ControlKey:
                    op = 'S';
                    break;
                    
                case Keys.Escape:
                    op = 'E';
                    break;
            }
            return op;
        }
    }
}
