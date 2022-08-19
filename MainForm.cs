using CometUI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegReader
{
	public partial class MainForm : CometForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Registry Reader

		private Dictionary<string, RegistryKey> _keyHives = new Dictionary<string, RegistryKey>
		{
			{ "HKEY_CLASSES_ROOT", Registry.ClassesRoot },
			{ "HKEY_CURRENT_USER", Registry.CurrentUser },
			{ "HKEY_LOCAL_MACHINE", Registry.LocalMachine },
			{ "HKEY_USERS", Registry.Users },
			{ "HKEY_CURRENT_CONFIG", Registry.CurrentConfig },
		};

		private void ReadSubkey(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPath.Text))
			{
				MessageBox.Show("Unable to read Registry because no path to a key was specified.", "Key Path Required",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (string.IsNullOrEmpty(txtKey.Text))
			{
				MessageBox.Show("Unable to read Registry because no key to read was specified.", "Key Name Required",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (string.IsNullOrEmpty(txtValue.Text))
			{
				MessageBox.Show("Unable to read Registry because no value to read was specified.", "Key Value Name Required",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				string keyHiveName = txtPath.Text.Substring(0, txtPath.Text.IndexOf('\\'));
				RegistryKey selectedHive = _keyHives[keyHiveName];
				object keyValue = selectedHive.OpenSubKey(txtPath.Text.Substring(keyHiveName.Length + 1) + "\\" + txtKey.Text).GetValue(txtValue.Text);
				Type valueType = keyValue.GetType();

				if (valueType == typeof(string))
					txtReadResult.Text = keyValue.ToString();
				else if (valueType == typeof(byte[]))
					txtReadResult.Text = ReadBinaryValue((byte[])keyValue);
				else if (valueType == typeof(int))
					txtReadResult.Text = ReadDWORDValue((int)keyValue);
				else if (valueType == typeof(long))
					txtReadResult.Text = ReadQWORDValue((long)keyValue);
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error has occurred when attempting to read the specified key/value.\n" +
					"This is because either the root key specified is not supported, the key specified does not exist, or the value specified does not exist.\n\n" +
					"Please make sure you have entered the information correctly when attempting to read the Registry.", "Unable To Read Registry",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show("For debug purposes, the love of errors, or just if you are testing this program's capabilities, here is the error information:\n\n" +
					exc.Message + "\n\nStack Trace:\n" + exc.StackTrace, "Error Debug Info",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private string ReadBinaryValue(byte[] value)
		{
			StringBuilder strBuild = new StringBuilder();

			foreach (byte binary in value)
				strBuild.Append((char)binary);

			return strBuild.ToString();
		}

		private string ReadDWORDValue(int value)
		{
			return value.ToString();
		}

		private string ReadQWORDValue(long value)
		{
			return value.ToString() + 'L';
		}

		#endregion
	}
}
