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

            //setSql
            //declare method boolean "setSql" with string "query"
            //declare boolean variable "result"
            // set result to false
            //declare try
            {
                //get global variable connection
                //open the connection
                //get global variable command
                //set global variable command param with "query" and "connection"
                //set global variable command get executenonquery query method
                //close the connection
                //set result to true
            }
            //declare catch
            {
                // set message box to error
                //close the connection
            }
            //return result
            //close connection
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

            //declare getSql datatable method with string parameter as "query"
            //declare global variable datatable and set new instance
            //declare try
            {
                //declare global variable connection then set connection to open
                //declare global variable dataadapter then make new sqlcommandadapter instance then set sqlcommandadapter with parameter query and connection
                //set global variable dataadapter with fill method params datatable
                //close connection
            }
            //declare catch
            {
                //message box fail
                //close connection
            }
            //return datatable
            //close connection
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
                    sql = $"INSERT INTO MsMenu (name, price, carbo, protein  {(img != null ? ", photo" : "")}  ) VALUES('{menu[1]}', '{int.Parse(menu[2])}', '{int.Parse(menu[4])}', '{int.Parse(menu[5])}' {(img != null ? ", @photo" : "")} )";
                    cmd = new SqlCommand(sql, Gv.con);

                    //if (img != null)
                    //    cmd.Parameters.AddWithValue("@photo", img);

                    cmd.ExecuteNonQuery();
                    result = true;
                    Gv.Pesan("Berhasil", true);
                }
                else if (status == "update")
                {
                    sql = $"UPDATE MsMenu SET name = '{menu[1]}', price = '{int.Parse(menu[2])}', carbo = {int.Parse(menu[4])}, protein = '{int.Parse(menu[5])}' { (img != null ? ", photo = @photo" : "")}  WHERE id = '{menu[0]}'";
                    cmd = new SqlCommand(sql, Gv.con);
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

            //declare bool method ManageMenu() with params string status string[] menu
            //declare bool result var;
            // declare string sql var;
            // declare byte[] img var set to null;
            //try
            {
                //global variable connection access method open

                //declare if menu[3] is not null
                {
                    //declare filestream fs variable then create new instance with Menu[3], Filemode.Open, Fileacces.Read (meh bisa ngabaca variable image nu, pan diakses lewat file matak disetna fileaccess.read jeng filemode. open)
                    // declare BinaryStream bs variable then create new intance with fs (ngajien binarystream meh ngaconvert filestream nu jang gambarna tadi, matak ngajien instance anyar binarystream nu paramsna isina nya filestream na)
                    // Set img variable to BinarySteam bs accessing to ReadByte method with filestream fs length and (tinggal di set we variable image teh ku binarystream jeng ngabaca byte na make method readbyte nu ngambil parameter na teh ku panjang dari filestream na, matak di cast na ku int)
                }

                //declare if status from method params is set to insert
                {
                    // set sql var to $"INSERT INTO MsMenu (name, price, carbo, protein {( img != null ? ", photo" : ""  )} ) VALUES ('{menu[1]', {Int.Parse([menu[2])}, {Int.Parse([menu[4})}, {Int.Parse(menu[5])}, {(img != null ? ", '{Menu[3]}'" : "")} ));
                    // global variable command with string sql, global variable connection
                    // command execute non query
                    //result = true;
                    //messagebox berhasil
                }
                //declare if status from method params is set to update
                {
                    //set sql var to $"UPDATE MsMenu SET name = '{menu[1]}', price = {Int.Parse(menu[2]}, carbo = {Int.Parse(menu[4])}, protein = {Int.Parse(menu[5])} {(img != null ? ", photo = {menu[3]}" : "")}  )"
                    //global variable command with sql string, global variable connection
                    //command execute non query
                    // result = true;
                    // messagebox berhasil
                }
                // global variable connection close
            } //catch (Exception ex)
            {
                //messagebox gagal mengambil data, messagebox.iconok. messagebox warning
                // global variable connection close
            }
            //return result
        }

        public byte[] displayImg(string id)
        {
            byte[] img = null;
            Gv.dt = new DataTable();
            try
            {
                Gv.con.Open();
                Gv.da = new SqlDataAdapter($"select photo from MsMenu where id = '{id}'", Gv.con);
                Gv.da.Fill(Gv.dt);
                if (Gv.dt.Rows[0][0] != null)
                {
                    img = (byte[])Gv.dt.Rows[0][0];
                }
                Gv.con.Close();
            }
            catch (Exception ex)
            {
                Gv.Pesan($"Photo Gagal Diambil / Tidak ada {ex.Message} ", false);
                Gv.con.Close();
            }
            return img;

            //declare method DisplayImage with byte[] "id" params
            {
                //declare byte img variable; (karena image itu kita membaca byte nya)
                //global variable dt new datatable;
                //declare sql string variable set to $"SELECT phot0 from MsMenu where id = {id}"
                //try
                {
                    //global variable connection open
                    //global variable da then make new instance sql data adapter with sql and connection
                    //global variable data adapter fill with dt
                    //declare if data table rows 0 cell 0 (datatable.row[0][0]) is less than zero
                    {
                        //set img = (byte[])datatable rows 0 cell 0  (byte[])Gv.dt.Rows[0][0]
                        //global variable connection close
                    }
                }
                //catch
                {
                    //messagebox error
                    //global variable conenction close
                }
                //return img
            }
        }

        public string orderId()
        {
            string orderID = "";
            try
            {
                string today = DateTime.Today.ToString("yyyyMMdd");
                Gv.dt = getSql($"SELECT id FROM orderHeader WHERE id LIKE '{today}%' ORDER BY id DESC");
                if (Gv.dt.Rows.Count > 0)
                {
                    string id = Gv.dt.Rows[0][0].ToString();
                    int increment = int.Parse(id.Substring(8)) + 1;
                    orderID = $"{today}{increment:0000}";
                }
                else
                {
                    orderID = $"{today}0001";
                }
            }
            catch (Exception ex)
            {
                Gv.Pesan($"Gagal Generate ID {ex.Message}", true);
            }
            return orderID;
        }
    }
}