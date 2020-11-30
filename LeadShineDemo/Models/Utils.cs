using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeadShineDemo.Model
{
    class db_helper
    {
        private static db_helper helper;
        private SQLiteConnection mConnection;
        public static db_helper getInstance()
        {
            if(helper == null)
            {
                helper = new db_helper();
            }
            return helper;
        }

        private db_helper()
        {
            mConnection = new SQLiteConnection("DataSource=lenovo01-kbd-db.sqlite;Version=3");
        }

        public Dictionary<int, Keycode> getKeycodes()
        {
            mConnection.Open();
            string sql = "Select * from keycode";
            SQLiteCommand cmd = new SQLiteCommand(sql, mConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Dictionary<int, Keycode> dict = new Dictionary<int, Keycode>();

            while(reader.Read())
            {
                int vk_code = Convert.ToInt32(reader["vk_code"]);
                int sc_code = Convert.ToInt32(reader["sc_code"]);
                string name = reader["name"] as string;

                dict[vk_code] = new Keycode() { vk_code = vk_code, sc_code = sc_code, name = name };
            }

            reader.Close();
            mConnection.Close();

            return dict;
        }

        public List<KeyInfo> getKeymap()
        {
            mConnection.Open();
            string sql = "select * from keymap";

            SQLiteCommand cmd = new SQLiteCommand(sql, mConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<KeyInfo> list = new List<KeyInfo>();

            while(reader.Read())
            {
                int left = Convert.ToInt32(reader["left"]);
                int top = Convert.ToInt32(reader["top"]);
                int width = Convert.ToInt32(reader["width"]);
                int height = Convert.ToInt32(reader["height"]);
                int vk_code = Convert.ToInt32(reader["vk_code"]);

                list.Add(new KeyInfo() { left = left, top = top, width = width, height = height, vk_code = vk_code});
            }

            reader.Close();
            mConnection.Close();

            return list;
        }

        public bool updateMotionData(int id, double x, double y, double z, int vkcode)
        {
            try
            {
                mConnection.Open();
                string sql = $"update keymotionmap set id = {id},x = {x},y = {y},z = {z} where vk_code = {vkcode}";
                SQLiteCommand cmd = new SQLiteCommand(sql, mConnection);
                int r = cmd.ExecuteNonQuery();
                if (r < 1)
                {
                    sql = $"insert into keymotionmap (id,x,y,z,vk_code) values ({id},{x},{y},{z},{vkcode})";
                    cmd = new SQLiteCommand(sql, mConnection);
                    r = cmd.ExecuteNonQuery();
                    if (r > 1)
                    {
                        mConnection.Close();
                        return true;
                    }
                    else
                    {
                        mConnection.Close();
                        return false;
                    }
                }
                mConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mConnection.Close();
                return false;
            }
        }
        public List<KeyMotionInfo> getKeyMotionmap()
        {
            mConnection.Open();
            string sql = "select * from keymotionmap";

            SQLiteCommand cmd = new SQLiteCommand(sql, mConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<KeyMotionInfo> list = new List<KeyMotionInfo>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                double x = Convert.ToDouble(reader["x"]);
                double y = Convert.ToDouble(reader["y"]);
                double z = Convert.ToDouble(reader["z"]);
                int vk_code = Convert.ToInt32(reader["vk_code"]);

                list.Add(new KeyMotionInfo() { id = id, x = x, y = y, z = z, vk_code = vk_code });
            }

            reader.Close();
            mConnection.Close();

            return list;
        }
    }

    class Utils
    {
        static Dictionary<int, Keycode> keycodes;
        static List<KeyInfo> keymap;
        static List<KeyMotionInfo> keymotionmap;

        static public Keycode getKeycodeByVkCode(int vk_code)
        {
            if (keycodes == null)
            {
                db_helper helper = db_helper.getInstance();
                keycodes = helper.getKeycodes();
            }

            if (keycodes.ContainsKey(vk_code))
            {
                return keycodes[vk_code];
            }
            else
            {
                return null;
            }
        }

        static public List<KeyInfo> getKeymap()
        {
            if(keymap == null)
            {
                db_helper helper = db_helper.getInstance();
                keymap = helper.getKeymap();
            }

            return keymap;
        }
        static public List<KeyMotionInfo> getKeymotionmap()
        {
            if (keymotionmap == null)
            {
                db_helper helper = db_helper.getInstance();
                keymotionmap = helper.getKeyMotionmap();
            }

            return keymotionmap;
        }

        static public List<Keycode> getKeycodes()
        {
            if (keycodes == null)
            {
                db_helper helper = db_helper.getInstance();
                keycodes = helper.getKeycodes();
            }

            var list = new List<Keycode>();

            foreach(var code in keycodes)
            {
                list.Add(code.Value);
            }

            return list;
        }
        static public bool updateMotionData(int id, double x, double y, double z, int vkcode)
        {
            db_helper helper = db_helper.getInstance();
            return helper.updateMotionData(id, x, y, z, vkcode);
        }
        static public int VkToSc(int vk_code)
        {
            return 0;
        }

        [DllImport("user32.dll")]
        static extern int MapVirtualKey(int uCode, uint uMapType);
    }
}
