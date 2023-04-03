using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LATIHANMEMBUATCRUD
{
    public class sqlComponent
    {
        public bool setSql(string Text)
        {
            Boolean result = false;

            try
            {
                Gv.con.Open();
                Gv.cmd = new SqlCommand(Text, Gv.con);
                Gv.cmd.ExecuteNonQuery();
                Gv.con.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Gv.Pesan("Gagal Connect (" + ex.Message + ")", false);
            }
            return result;

            // kita memakai try dan catch untuk mengecek jika terjadi error atau tidak. Pertama tama memanggil Variable Con yang pada class GV yang berisi sqlcommand()
            //kita panggil gv.cmd untuk sqlcommand dan memasukan parameter text dan koneksinya: new SqlCommand(query, connection)
            //lalu kita execute querynya dengan ExecuteNonQuery
            //lalu selepas itu kita close
            //jika berhasil maka boolean result yang awalnya true jadi false
        }

        public DataTable getSql(String Text) //buat function data table menggunakan Datatable bukan void kawokwoako, juga buat parameter nya sebagai teks
        {
            Gv.dt = new DataTable(); //buat intansi untuk datatable sesuai dengan variable yang component datatable seperti yang ada di global var
            try
            {
                Gv.con.Open(); //seperti biasa, kita open dulu koneksinya
                Gv.da = new SqlDataAdapter(Text, Gv.con);
                Gv.da.Fill(Gv.dt); //kita panggil method yang ada di dataadapter yaitu method fill dan isi method fillnya dengan data table ini teh masukin dataadapternya ke datatable
                Gv.con.Close();
            }
            catch (Exception ex)
            {
                Gv.Pesan("gagal dapat data", false);
                Gv.con.Close();
            }
            return Gv.dt;
            Gv.con.Close();
        }

        public bool manageMenuController(string status, string[] menu)
        {
            bool result = false;
            string sql = "";
            byte[] img = null;
            SqlCommand cmd;

            try
            {
                Gv.con.Open();

                if (menu[3] != "")
                {
                    FileStream fs = new FileStream(menu[3], FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }

                if (status == "insert")
                {
                    sql = "INSERT INTO MsMenu (name, price, carbo, protein" + (img != null ? ", photo" : "") + ") VALUES(@name, @price, @carbo, @protein" + (img != null ? ", @photo" : "") + ")";
                    cmd = new SqlCommand(sql, Gv.con);
                    cmd.Parameters.AddWithValue("@name", menu[1]);
                    cmd.Parameters.AddWithValue("@price", int.Parse(menu[2]));
                    cmd.Parameters.AddWithValue("@carbo", int.Parse(menu[4]));
                    cmd.Parameters.AddWithValue("@protein", int.Parse(menu[5]));

                    if (img != null)
                        cmd.Parameters.AddWithValue("@photo", img);

                    cmd.ExecuteNonQuery();
                    result = true;
                    Gv.Pesan("Berhasil", true);
                }
                else if (status == "update")
                {
                    sql = "UPDATE MsMenu SET name = @name, price = @price, carbo = @carbo, protein = @protein" + (img != null ? ", photo = @photo" : "") + " WHERE id = @id";
                    cmd = new SqlCommand(sql, Gv.con);
                    cmd.Parameters.AddWithValue("@id", menu[0]);
                    cmd.Parameters.AddWithValue("@name", menu[1]);
                    cmd.Parameters.AddWithValue("@price", int.Parse(menu[2]));
                    cmd.Parameters.AddWithValue("@carbo", int.Parse(menu[4]));
                    cmd.Parameters.AddWithValue("@protein", int.Parse(menu[5]));

                    if (img != null)
                        cmd.Parameters.AddWithValue("@photo", img);

                    cmd.ExecuteNonQuery();
                    result = true;
                    Gv.Pesan("Berhasil", true);
                }

                Gv.con.Close();
            }
            catch (Exception ex)
            {
                Gv.Pesan("Gagal (" + ex.Message + ") ", false);
                Gv.con.Close();
            }

            return result;
        }

        public byte[] displayImg(string id)
        {
            byte[] img = null;
            Gv.dt = new DataTable();
            try
            {
                Gv.con.Open();
                Gv.da = new SqlDataAdapter("select photo from MsMenu where id = @id", Gv.con);
                Gv.da.SelectCommand.Parameters.AddWithValue("@id", id);
                Gv.da.Fill(Gv.dt);
                if (Gv.dt.Rows[0][0] != null)
                {
                    img = (byte[])Gv.dt.Rows[0][0];
                }
                Gv.con.Close();
            }
            catch (Exception ex)
            {
                Gv.Pesan("Photo Gagal Diambil / Tidak ada" + ex.Message + " ", false);
                Gv.con.Close();
            }
            return img;
        }
    }
}