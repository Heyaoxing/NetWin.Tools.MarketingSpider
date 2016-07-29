using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

using Shove.Database;

namespace DAL
{
	/*
	Program Name: Shove.DAL.30 for MySQL
	Program Version: 3.0
	Writer By: 3km.shovesoft.shove (zhou changjun)
	Release Time: 2009.7.16

	System Request: Shove.dll, MySql.Data.dll, MySql.Data.Entity.dll, MySql.Web.dll
	All Rights saved.
	*/


	// Please Add a Key in Web.config File's appSetting section, Exemple:
	// <add key="ConnectionString" value="server=localhost;user id=root;password=;database=test;port=3306;" />


	public class Tables
	{
		public class aa : MySQL.TableBase
		{
			public MySQL.Field a;

			public aa()
			{
				TableName = "aa";

				a = new MySQL.Field(this, "a", "a", MySqlDbType.Int24, false);
			}
		}

		public class temp_chineseword : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field word_name;

			public temp_chineseword()
			{
				TableName = "temp_chineseword";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				word_name = new MySQL.Field(this, "word_name", "word_name", MySqlDbType.VarChar, false);
			}
		}

		public class t_all_config : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field type;
			public MySQL.Field content;

			public t_all_config()
			{
				TableName = "t_all_config";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
			}
		}

		public class t_areas : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field city_id;
			public MySQL.Field name;
			public MySQL.Field data_version;

			public t_areas()
			{
				TableName = "t_areas";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				city_id = new MySQL.Field(this, "city_id", "city_id", MySqlDbType.Int32, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				data_version = new MySQL.Field(this, "data_version", "data_version", MySqlDbType.Int64, false);
			}
		}

		public class t_artical : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field title;
			public MySQL.Field content;
			public MySQL.Field content_txt;
			public MySQL.Field cause;
			public MySQL.Field user_id;
			public MySQL.Field release_id;
			public MySQL.Field product_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field approve_flag;
			public MySQL.Field release_flag;
			public MySQL.Field is_erased;
			public MySQL.Field is_front;

			public t_artical()
			{
				TableName = "t_artical";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_txt = new MySQL.Field(this, "content_txt", "content_txt", MySqlDbType.Text, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				approve_flag = new MySQL.Field(this, "approve_flag", "approve_flag", MySqlDbType.Int32, false);
				release_flag = new MySQL.Field(this, "release_flag", "release_flag", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_front = new MySQL.Field(this, "is_front", "is_front", MySqlDbType.Bit, false);
			}
		}

		public class t_artical_approve : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field artical_id;
			public MySQL.Field cause;
			public MySQL.Field approver_id;
			public MySQL.Field is_erased;
			public MySQL.Field create_time;

			public t_artical_approve()
			{
				TableName = "t_artical_approve";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				artical_id = new MySQL.Field(this, "artical_id", "artical_id", MySqlDbType.Int64, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
				approver_id = new MySQL.Field(this, "approver_id", "approver_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_authority_module : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field parent_id;
			public MySQL.Field url;
			public MySQL.Field is_menu;
			public MySQL.Field sort;
			public MySQL.Field is_erased;

			public t_authority_module()
			{
				TableName = "t_authority_module";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				is_menu = new MySQL.Field(this, "is_menu", "is_menu", MySqlDbType.Int32, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_module_bak : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field parent_id;
			public MySQL.Field url;
			public MySQL.Field sort;
			public MySQL.Field is_erased;

			public t_authority_module_bak()
			{
				TableName = "t_authority_module_bak";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_module_permissions : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field sort;
			public MySQL.Field is_erased;

			public t_authority_module_permissions()
			{
				TableName = "t_authority_module_permissions";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_m_p : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field module_id;
			public MySQL.Field permissions_id;
			public MySQL.Field is_erased;

			public t_authority_m_p()
			{
				TableName = "t_authority_m_p";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				module_id = new MySQL.Field(this, "module_id", "module_id", MySqlDbType.Int64, false);
				permissions_id = new MySQL.Field(this, "permissions_id", "permissions_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_roles : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field description;
			public MySQL.Field sort;
			public MySQL.Field is_erased;

			public t_authority_roles()
			{
				TableName = "t_authority_roles";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.VarChar, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_role_permissions : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field roles_id;
			public MySQL.Field module_id;
			public MySQL.Field permissions_id;
			public MySQL.Field is_erased;

			public t_authority_role_permissions()
			{
				TableName = "t_authority_role_permissions";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				roles_id = new MySQL.Field(this, "roles_id", "roles_id", MySqlDbType.Int64, false);
				module_id = new MySQL.Field(this, "module_id", "module_id", MySqlDbType.Int64, false);
				permissions_id = new MySQL.Field(this, "permissions_id", "permissions_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_role_permissions_bak : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field roles_id;
			public MySQL.Field module_id;
			public MySQL.Field permissions_id;
			public MySQL.Field is_erased;

			public t_authority_role_permissions_bak()
			{
				TableName = "t_authority_role_permissions_bak";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				roles_id = new MySQL.Field(this, "roles_id", "roles_id", MySqlDbType.Int64, false);
				module_id = new MySQL.Field(this, "module_id", "module_id", MySqlDbType.Int64, false);
				permissions_id = new MySQL.Field(this, "permissions_id", "permissions_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_authority_user_roles : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field eims_id;
			public MySQL.Field roles_id;
			public MySQL.Field description;
			public MySQL.Field create_time;
			public MySQL.Field create_id;
			public MySQL.Field is_erased;

			public t_authority_user_roles()
			{
				TableName = "t_authority_user_roles";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				roles_id = new MySQL.Field(this, "roles_id", "roles_id", MySqlDbType.Int64, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_id = new MySQL.Field(this, "create_id", "create_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_citys : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field province_id;
			public MySQL.Field name;
			public MySQL.Field data_version;

			public t_citys()
			{
				TableName = "t_citys";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				province_id = new MySQL.Field(this, "province_id", "province_id", MySqlDbType.Int32, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				data_version = new MySQL.Field(this, "data_version", "data_version", MySqlDbType.Int64, false);
			}
		}

		public class t_cloud_click_days_keywords : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field keyword_id;
			public MySQL.Field created_time;
			public MySQL.Field position;
			public MySQL.Field pre_click_times;
			public MySQL.Field click_times;

			public t_cloud_click_days_keywords()
			{
				TableName = "t_cloud_click_days_keywords";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int64, false);
				created_time = new MySQL.Field(this, "created_time", "created_time", MySqlDbType.DateTime, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				pre_click_times = new MySQL.Field(this, "pre_click_times", "pre_click_times", MySqlDbType.Int32, false);
				click_times = new MySQL.Field(this, "click_times", "click_times", MySqlDbType.Int32, false);
			}
		}

		public class t_cloud_click_ip_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field ip;
			public MySQL.Field keyword_id;

			public t_cloud_click_ip_log()
			{
				TableName = "t_cloud_click_ip_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int64, false);
			}
		}

		public class t_cloud_click_keywords : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field keyword;
			public MySQL.Field created_time;
			public MySQL.Field cur_position;

			public t_cloud_click_keywords()
			{
				TableName = "t_cloud_click_keywords";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				created_time = new MySQL.Field(this, "created_time", "created_time", MySqlDbType.DateTime, false);
				cur_position = new MySQL.Field(this, "cur_position", "cur_position", MySqlDbType.VarChar, false);
			}
		}

		public class t_cloud_click_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_agent;
			public MySQL.Field cookie;
			public MySQL.Field ip;
			public MySQL.Field create_time;
			public MySQL.Field url;
			public MySQL.Field status;
			public MySQL.Field release_id;
			public MySQL.Field keyword_id;
			public MySQL.Field info;

			public t_cloud_click_log()
			{
				TableName = "t_cloud_click_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				user_agent = new MySQL.Field(this, "user_agent", "user_agent", MySqlDbType.Text, false);
				cookie = new MySQL.Field(this, "cookie", "cookie", MySqlDbType.Text, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.Text, false);
				status = new MySQL.Field(this, "status", "status", MySqlDbType.Int32, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int64, false);
				info = new MySQL.Field(this, "info", "info", MySqlDbType.Text, false);
			}
		}

		public class t_cloud_click_log_detail : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_agent;
			public MySQL.Field cookie;
			public MySQL.Field ip;
			public MySQL.Field create_time;
			public MySQL.Field url;
			public MySQL.Field log_id;
			public MySQL.Field release_id;
			public MySQL.Field keyword_id;

			public t_cloud_click_log_detail()
			{
				TableName = "t_cloud_click_log_detail";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				user_agent = new MySQL.Field(this, "user_agent", "user_agent", MySqlDbType.Text, false);
				cookie = new MySQL.Field(this, "cookie", "cookie", MySqlDbType.Text, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.Text, false);
				log_id = new MySQL.Field(this, "log_id", "log_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int64, false);
			}
		}

		public class t_cloud_click_profile : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field position;
			public MySQL.Field click_times;
			public MySQL.Field is_stop;

			public t_cloud_click_profile()
			{
				TableName = "t_cloud_click_profile";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				click_times = new MySQL.Field(this, "click_times", "click_times", MySqlDbType.Int32, false);
				is_stop = new MySQL.Field(this, "is_stop", "is_stop", MySqlDbType.Bit, false);
			}
		}

		public class t_cloud_click_profile_items : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field profile_id;
			public MySQL.Field begin;
			public MySQL.Field end;
			public MySQL.Field click_times;

			public t_cloud_click_profile_items()
			{
				TableName = "t_cloud_click_profile_items";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				profile_id = new MySQL.Field(this, "profile_id", "profile_id", MySqlDbType.Int64, false);
				begin = new MySQL.Field(this, "begin", "begin", MySqlDbType.Time, false);
				end = new MySQL.Field(this, "end", "end", MySqlDbType.Time, false);
				click_times = new MySQL.Field(this, "click_times", "click_times", MySqlDbType.Int32, false);
			}
		}

		public class t_cw_cooperation_platform : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field url;
			public MySQL.Field big_img_path;
			public MySQL.Field small_img_path;
			public MySQL.Field month;
			public MySQL.Field remarks;
			public MySQL.Field copyright;
			public MySQL.Field flux_count;
			public MySQL.Field create_time;
			public MySQL.Field is_publish;
			public MySQL.Field is_threelevels;
			public MySQL.Field prohibited_words;
			public MySQL.Field is_erased;

			public t_cw_cooperation_platform()
			{
				TableName = "t_cw_cooperation_platform";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				big_img_path = new MySQL.Field(this, "big_img_path", "big_img_path", MySqlDbType.VarChar, false);
				small_img_path = new MySQL.Field(this, "small_img_path", "small_img_path", MySqlDbType.VarChar, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				remarks = new MySQL.Field(this, "remarks", "remarks", MySqlDbType.VarChar, false);
				copyright = new MySQL.Field(this, "copyright", "copyright", MySqlDbType.VarChar, false);
				flux_count = new MySQL.Field(this, "flux_count", "flux_count", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_publish = new MySQL.Field(this, "is_publish", "is_publish", MySqlDbType.Bit, false);
				is_threelevels = new MySQL.Field(this, "is_threelevels", "is_threelevels", MySqlDbType.Bit, false);
				prohibited_words = new MySQL.Field(this, "prohibited_words", "prohibited_words", MySqlDbType.Text, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_friendly_link : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cooperation_platform_id;
			public MySQL.Field site_id;
			public MySQL.Field link_name;
			public MySQL.Field link_address;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_cw_friendly_link()
			{
				TableName = "t_cw_friendly_link";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cooperation_platform_id = new MySQL.Field(this, "cooperation_platform_id", "cooperation_platform_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				link_name = new MySQL.Field(this, "link_name", "link_name", MySqlDbType.VarChar, false);
				link_address = new MySQL.Field(this, "link_address", "link_address", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_platform_artical : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cooperation_platform_id;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field artical_id;
			public MySQL.Field word2_title_his_yid;
			public MySQL.Field status;
			public MySQL.Field read_count;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_cw_platform_artical()
			{
				TableName = "t_cw_platform_artical";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cooperation_platform_id = new MySQL.Field(this, "cooperation_platform_id", "cooperation_platform_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				artical_id = new MySQL.Field(this, "artical_id", "artical_id", MySqlDbType.Int64, false);
				word2_title_his_yid = new MySQL.Field(this, "word2_title_his_yid", "word2_title_his_yid", MySqlDbType.Int64, false);
				status = new MySQL.Field(this, "status", "status", MySqlDbType.Bit, false);
				read_count = new MySQL.Field(this, "read_count", "read_count", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_site_assignment : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cooperation_platform_id;
			public MySQL.Field site_id;
			public MySQL.Field product_id;
			public MySQL.Field artical_id;
			public MySQL.Field is_insert;
			public MySQL.Field type_id;
			public MySQL.Field status;
			public MySQL.Field create_time;
			public MySQL.Field update_time;

			public t_cw_site_assignment()
			{
				TableName = "t_cw_site_assignment";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cooperation_platform_id = new MySQL.Field(this, "cooperation_platform_id", "cooperation_platform_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				artical_id = new MySQL.Field(this, "artical_id", "artical_id", MySqlDbType.Int64, false);
				is_insert = new MySQL.Field(this, "is_insert", "is_insert", MySqlDbType.Int32, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int32, false);
				status = new MySQL.Field(this, "status", "status", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
			}
		}

		public class t_cw_site_day : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field is_list;
			public MySQL.Field is_erased;

			public t_cw_site_day()
			{
				TableName = "t_cw_site_day";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.VarChar, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.VarChar, false);
				is_list = new MySQL.Field(this, "is_list", "is_list", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_site_html : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cooperation_platform_id;
			public MySQL.Field site_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_cw_site_html()
			{
				TableName = "t_cw_site_html";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cooperation_platform_id = new MySQL.Field(this, "cooperation_platform_id", "cooperation_platform_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_site_html_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cooperation_platform_id;
			public MySQL.Field site_id;
			public MySQL.Field product_id;
			public MySQL.Field artical_id;
			public MySQL.Field web_name;
			public MySQL.Field title;
			public MySQL.Field img_path;
			public MySQL.Field web_link;
			public MySQL.Field type_id;
			public MySQL.Field trade_id;
			public MySQL.Field read_count;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_cw_site_html_list()
			{
				TableName = "t_cw_site_html_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cooperation_platform_id = new MySQL.Field(this, "cooperation_platform_id", "cooperation_platform_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				artical_id = new MySQL.Field(this, "artical_id", "artical_id", MySqlDbType.Int64, false);
				web_name = new MySQL.Field(this, "web_name", "web_name", MySqlDbType.VarChar, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				img_path = new MySQL.Field(this, "img_path", "img_path", MySqlDbType.VarChar, false);
				web_link = new MySQL.Field(this, "web_link", "web_link", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int32, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int32, false);
				read_count = new MySQL.Field(this, "read_count", "read_count", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_site_html_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field web_name;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_cw_site_html_type()
			{
				TableName = "t_cw_site_html_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				web_name = new MySQL.Field(this, "web_name", "web_name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_site_img : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field title;
			public MySQL.Field img_path;
			public MySQL.Field a_link;
			public MySQL.Field type;
			public MySQL.Field is_erased;
			public MySQL.Field is_proscenium;
			public MySQL.Field create_time;

			public t_cw_site_img()
			{
				TableName = "t_cw_site_img";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				img_path = new MySQL.Field(this, "img_path", "img_path", MySqlDbType.VarChar, false);
				a_link = new MySQL.Field(this, "a_link", "a_link", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_proscenium = new MySQL.Field(this, "is_proscenium", "is_proscenium", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_cw_template : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field name;
			public MySQL.Field description;
			public MySQL.Field is_erased;

			public t_cw_template()
			{
				TableName = "t_cw_template";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_template_choose : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field template_id;
			public MySQL.Field platform_id;
			public MySQL.Field trade_id;
			public MySQL.Field site_id;

			public t_cw_template_choose()
			{
				TableName = "t_cw_template_choose";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				template_id = new MySQL.Field(this, "template_id", "template_id", MySqlDbType.Int64, false);
				platform_id = new MySQL.Field(this, "platform_id", "platform_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
			}
		}

		public class t_cw_template_data : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field name;
			public MySQL.Field data_scope;
			public MySQL.Field type;
			public MySQL.Field available_field;
			public MySQL.Field comment;
			public MySQL.Field reference_value;
			public MySQL.Field is_erased;

			public t_cw_template_data()
			{
				TableName = "t_cw_template_data";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				data_scope = new MySQL.Field(this, "data_scope", "data_scope", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				available_field = new MySQL.Field(this, "available_field", "available_field", MySqlDbType.VarChar, false);
				comment = new MySQL.Field(this, "comment", "comment", MySqlDbType.VarChar, false);
				reference_value = new MySQL.Field(this, "reference_value", "reference_value", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_cw_template_data_attr : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field name;
			public MySQL.Field type;
			public MySQL.Field comment;
			public MySQL.Field reference_value;
			public MySQL.Field is_erased;

			public t_cw_template_data_attr()
			{
				TableName = "t_cw_template_data_attr";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				comment = new MySQL.Field(this, "comment", "comment", MySqlDbType.VarChar, false);
				reference_value = new MySQL.Field(this, "reference_value", "reference_value", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_config_exponential : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field min_exponential;
			public MySQL.Field max_exponential;
			public MySQL.Field unit_price;
			public MySQL.Field long_time;
			public MySQL.Field rebate;
			public MySQL.Field price;

			public t_m_config_exponential()
			{
				TableName = "t_m_config_exponential";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				min_exponential = new MySQL.Field(this, "min_exponential", "min_exponential", MySqlDbType.Int32, false);
				max_exponential = new MySQL.Field(this, "max_exponential", "max_exponential", MySqlDbType.Int32, false);
				unit_price = new MySQL.Field(this, "unit_price", "unit_price", MySqlDbType.Decimal, false);
				long_time = new MySQL.Field(this, "long_time", "long_time", MySqlDbType.Int32, false);
				rebate = new MySQL.Field(this, "rebate", "rebate", MySqlDbType.Decimal, false);
				price = new MySQL.Field(this, "price", "price", MySqlDbType.Decimal, false);
			}
		}

		public class t_m_config_include_price : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field min_include_amount;
			public MySQL.Field max_include_amount;
			public MySQL.Field include_ratio;

			public t_m_config_include_price()
			{
				TableName = "t_m_config_include_price";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				min_include_amount = new MySQL.Field(this, "min_include_amount", "min_include_amount", MySqlDbType.Int32, false);
				max_include_amount = new MySQL.Field(this, "max_include_amount", "max_include_amount", MySqlDbType.Int32, false);
				include_ratio = new MySQL.Field(this, "include_ratio", "include_ratio", MySqlDbType.Int32, false);
			}
		}

		public class t_m_config_include_ratio : MySQL.TableBase
		{
			public MySQL.Field exponential_id;
			public MySQL.Field include_ratio;

			public t_m_config_include_ratio()
			{
				TableName = "t_m_config_include_ratio";

				exponential_id = new MySQL.Field(this, "exponential_id", "exponential_id", MySqlDbType.Int32, false);
				include_ratio = new MySQL.Field(this, "include_ratio", "include_ratio", MySqlDbType.Decimal, false);
			}
		}

		public class t_m_config_long_other : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field search_type;
			public MySQL.Field page_type;
			public MySQL.Field discount;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_config_long_other()
			{
				TableName = "t_m_config_long_other";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				discount = new MySQL.Field(this, "discount", "discount", MySqlDbType.Decimal, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_config_seo_ratio : MySQL.TableBase
		{
			public MySQL.Field exponential_id;
			public MySQL.Field default_value;
			public MySQL.Field seo_ratio;

			public t_m_config_seo_ratio()
			{
				TableName = "t_m_config_seo_ratio";

				exponential_id = new MySQL.Field(this, "exponential_id", "exponential_id", MySqlDbType.Int32, false);
				default_value = new MySQL.Field(this, "default_value", "default_value", MySqlDbType.Int32, false);
				seo_ratio = new MySQL.Field(this, "seo_ratio", "seo_ratio", MySqlDbType.Decimal, false);
			}
		}

		public class t_m_day_money : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field remainder;
			public MySQL.Field consume_money;
			public MySQL.Field is_not_enough_m;
			public MySQL.Field is_remind;
			public MySQL.Field create_time;
			public MySQL.Field write_count;
			public MySQL.Field is_erased;
			public MySQL.Field last_remind_time;

			public t_m_day_money()
			{
				TableName = "t_m_day_money";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				remainder = new MySQL.Field(this, "remainder", "remainder", MySqlDbType.Decimal, false);
				consume_money = new MySQL.Field(this, "consume_money", "consume_money", MySqlDbType.Decimal, false);
				is_not_enough_m = new MySQL.Field(this, "is_not_enough_m", "is_not_enough_m", MySqlDbType.Bit, false);
				is_remind = new MySQL.Field(this, "is_remind", "is_remind", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				write_count = new MySQL.Field(this, "write_count", "write_count", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				last_remind_time = new MySQL.Field(this, "last_remind_time", "last_remind_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_day_money_detailed : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field day_money_id;
			public MySQL.Field user_id;
			public MySQL.Field release_site_id;
			public MySQL.Field kw_trolley_id;
			public MySQL.Field kw_search_count_id;
			public MySQL.Field search_type;
			public MySQL.Field page_type;
			public MySQL.Field ranking;
			public MySQL.Field money;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_day_money_detailed()
			{
				TableName = "t_m_day_money_detailed";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				day_money_id = new MySQL.Field(this, "day_money_id", "day_money_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				kw_trolley_id = new MySQL.Field(this, "kw_trolley_id", "kw_trolley_id", MySqlDbType.Int64, false);
				kw_search_count_id = new MySQL.Field(this, "kw_search_count_id", "kw_search_count_id", MySqlDbType.Int64, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_day_money_detailed_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field keyType;
			public MySQL.Field keyName;
			public MySQL.Field create_time;
			public MySQL.Field baidu_ranking;
			public MySQL.Field so_ranking;
			public MySQL.Field sogou_ranking;
			public MySQL.Field baidu_snapshot;
			public MySQL.Field so_snapshot;
			public MySQL.Field sogou_snapshot;
			public MySQL.Field money;
			public MySQL.Field grab_time;
			public MySQL.Field user_id;
			public MySQL.Field is_erased;

			public t_m_day_money_detailed_count()
			{
				TableName = "t_m_day_money_detailed_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				keyType = new MySQL.Field(this, "keyType", "keyType", MySqlDbType.Int32, false);
				keyName = new MySQL.Field(this, "keyName", "keyName", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				baidu_ranking = new MySQL.Field(this, "baidu_ranking", "baidu_ranking", MySqlDbType.Int32, false);
				so_ranking = new MySQL.Field(this, "so_ranking", "so_ranking", MySqlDbType.Int32, false);
				sogou_ranking = new MySQL.Field(this, "sogou_ranking", "sogou_ranking", MySqlDbType.Int32, false);
				baidu_snapshot = new MySQL.Field(this, "baidu_snapshot", "baidu_snapshot", MySqlDbType.VarChar, false);
				so_snapshot = new MySQL.Field(this, "so_snapshot", "so_snapshot", MySqlDbType.VarChar, false);
				sogou_snapshot = new MySQL.Field(this, "sogou_snapshot", "sogou_snapshot", MySqlDbType.VarChar, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				grab_time = new MySQL.Field(this, "grab_time", "grab_time", MySqlDbType.DateTime, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Int32, false);
			}
		}

		public class t_m_day_money_leng_detailed : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field day_money_id;
			public MySQL.Field user_id;
			public MySQL.Field release_site_id;
			public MySQL.Field leng_keyword_id;
			public MySQL.Field search_count_id;
			public MySQL.Field search_type;
			public MySQL.Field page_type;
			public MySQL.Field ranking;
			public MySQL.Field money;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_day_money_leng_detailed()
			{
				TableName = "t_m_day_money_leng_detailed";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				day_money_id = new MySQL.Field(this, "day_money_id", "day_money_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				leng_keyword_id = new MySQL.Field(this, "leng_keyword_id", "leng_keyword_id", MySqlDbType.Int64, false);
				search_count_id = new MySQL.Field(this, "search_count_id", "search_count_id", MySqlDbType.Int64, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_deduction : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field way_id;
			public MySQL.Field money;
			public MySQL.Field begin_money;
			public MySQL.Field end_money;
			public MySQL.Field trade_id;
			public MySQL.Field trade_name;
			public MySQL.Field is_erased;

			public t_m_deduction()
			{
				TableName = "t_m_deduction";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				way_id = new MySQL.Field(this, "way_id", "way_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				begin_money = new MySQL.Field(this, "begin_money", "begin_money", MySqlDbType.Decimal, false);
				end_money = new MySQL.Field(this, "end_money", "end_money", MySqlDbType.Decimal, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.VarChar, false);
				trade_name = new MySQL.Field(this, "trade_name", "trade_name", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_deduction_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field is_erased;

			public t_m_deduction_type()
			{
				TableName = "t_m_deduction_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_deduction_t_way : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field deduction_type_id;
			public MySQL.Field name;
			public MySQL.Field is_select;
			public MySQL.Field is_erased;

			public t_m_deduction_t_way()
			{
				TableName = "t_m_deduction_t_way";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				deduction_type_id = new MySQL.Field(this, "deduction_type_id", "deduction_type_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				is_select = new MySQL.Field(this, "is_select", "is_select", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_delete_kw : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field user_id;
			public MySQL.Field kw_id;
			public MySQL.Field money;
			public MySQL.Field is_long_kw;
			public MySQL.Field create_time;
			public MySQL.Field is_fee_deduction;
			public MySQL.Field is_erased;

			public t_m_delete_kw()
			{
				TableName = "t_m_delete_kw";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				kw_id = new MySQL.Field(this, "kw_id", "kw_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				is_long_kw = new MySQL.Field(this, "is_long_kw", "is_long_kw", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_fee_deduction = new MySQL.Field(this, "is_fee_deduction", "is_fee_deduction", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_issue_rules : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_site_id;
			public MySQL.Field word_cloud_type;
			public MySQL.Field state;
			public MySQL.Field begin_day;
			public MySQL.Field end_day;
			public MySQL.Field create_time;

			public t_m_issue_rules()
			{
				TableName = "t_m_issue_rules";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				word_cloud_type = new MySQL.Field(this, "word_cloud_type", "word_cloud_type", MySqlDbType.Int32, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Bit, false);
				begin_day = new MySQL.Field(this, "begin_day", "begin_day", MySqlDbType.Int32, false);
				end_day = new MySQL.Field(this, "end_day", "end_day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_issue_rules_son : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field issue_rules_id;
			public MySQL.Field release_grade;
			public MySQL.Field release_select_number;
			public MySQL.Field release_number;
			public MySQL.Field thread_time_type;

			public t_m_issue_rules_son()
			{
				TableName = "t_m_issue_rules_son";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				issue_rules_id = new MySQL.Field(this, "issue_rules_id", "issue_rules_id", MySqlDbType.Int32, false);
				release_grade = new MySQL.Field(this, "release_grade", "release_grade", MySqlDbType.VarChar, false);
				release_select_number = new MySQL.Field(this, "release_select_number", "release_select_number", MySqlDbType.Int32, false);
				release_number = new MySQL.Field(this, "release_number", "release_number", MySqlDbType.Int32, false);
				thread_time_type = new MySQL.Field(this, "thread_time_type", "thread_time_type", MySqlDbType.Int24, false);
			}
		}

		public class t_m_kw_lexicon : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field name;
			public MySQL.Field source;
			public MySQL.Field state;
			public MySQL.Field is_shield;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field name_length;
			public MySQL.Field is_erased;

			public t_m_kw_lexicon()
			{
				TableName = "t_m_kw_lexicon";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				source = new MySQL.Field(this, "source", "source", MySqlDbType.Int24, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_shield = new MySQL.Field(this, "is_shield", "is_shield", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				name_length = new MySQL.Field(this, "name_length", "name_length", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_lexicon_hot : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field keyword_hash_id;
			public MySQL.Field keyword_name;
			public MySQL.Field hot_lexicon_name;
			public MySQL.Field show_case;
			public MySQL.Field search_quantity;
			public MySQL.Field mobile_search_quantity;
			public MySQL.Field guide_price;
			public MySQL.Field compete_level;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_m_kw_lexicon_hot()
			{
				TableName = "t_m_kw_lexicon_hot";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				keyword_hash_id = new MySQL.Field(this, "keyword_hash_id", "keyword_hash_id", MySqlDbType.Int64, false);
				keyword_name = new MySQL.Field(this, "keyword_name", "keyword_name", MySqlDbType.VarChar, false);
				hot_lexicon_name = new MySQL.Field(this, "hot_lexicon_name", "hot_lexicon_name", MySqlDbType.VarChar, false);
				show_case = new MySQL.Field(this, "show_case", "show_case", MySqlDbType.VarChar, false);
				search_quantity = new MySQL.Field(this, "search_quantity", "search_quantity", MySqlDbType.Int32, false);
				mobile_search_quantity = new MySQL.Field(this, "mobile_search_quantity", "mobile_search_quantity", MySqlDbType.Int32, false);
				guide_price = new MySQL.Field(this, "guide_price", "guide_price", MySqlDbType.Decimal, false);
				compete_level = new MySQL.Field(this, "compete_level", "compete_level", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_lexicon_hot_task : MySQL.TableBase
		{
			public MySQL.Field task_id;
			public MySQL.Field hash_id;
			public MySQL.Field lexicon_name;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field last_search_time;
			public MySQL.Field add_trolley_times;
			public MySQL.Field add_product_times;
			public MySQL.Field is_erased;

			public t_m_kw_lexicon_hot_task()
			{
				TableName = "t_m_kw_lexicon_hot_task";

				task_id = new MySQL.Field(this, "task_id", "task_id", MySqlDbType.Int64, true);
				hash_id = new MySQL.Field(this, "hash_id", "hash_id", MySqlDbType.Int64, false);
				lexicon_name = new MySQL.Field(this, "lexicon_name", "lexicon_name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				last_search_time = new MySQL.Field(this, "last_search_time", "last_search_time", MySqlDbType.DateTime, false);
				add_trolley_times = new MySQL.Field(this, "add_trolley_times", "add_trolley_times", MySqlDbType.Int32, false);
				add_product_times = new MySQL.Field(this, "add_product_times", "add_product_times", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_lexicon_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field kw_lexicon_id;
			public MySQL.Field name;
			public MySQL.Field is_one;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;

			public t_m_kw_lexicon_release()
			{
				TableName = "t_m_kw_lexicon_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				kw_lexicon_id = new MySQL.Field(this, "kw_lexicon_id", "kw_lexicon_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				is_one = new MySQL.Field(this, "is_one", "is_one", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_kw_l_exponential : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field kw_lexicon_id;
			public MySQL.Field lxponential;
			public MySQL.Field l_exponential_url;
			public MySQL.Field included_quantity;
			public MySQL.Field included_quantity_url;
			public MySQL.Field index_web;
			public MySQL.Field index_number;
			public MySQL.Field evaluate;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_kw_l_exponential()
			{
				TableName = "t_m_kw_l_exponential";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				kw_lexicon_id = new MySQL.Field(this, "kw_lexicon_id", "kw_lexicon_id", MySqlDbType.Int64, false);
				lxponential = new MySQL.Field(this, "lxponential", "lxponential", MySqlDbType.Int32, false);
				l_exponential_url = new MySQL.Field(this, "l_exponential_url", "l_exponential_url", MySqlDbType.VarChar, false);
				included_quantity = new MySQL.Field(this, "included_quantity", "included_quantity", MySqlDbType.Int32, false);
				included_quantity_url = new MySQL.Field(this, "included_quantity_url", "included_quantity_url", MySqlDbType.VarChar, false);
				index_web = new MySQL.Field(this, "index_web", "index_web", MySqlDbType.Int32, false);
				index_number = new MySQL.Field(this, "index_number", "index_number", MySqlDbType.Int32, false);
				evaluate = new MySQL.Field(this, "evaluate", "evaluate", MySqlDbType.Int32, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_trolley_id;
			public MySQL.Field key_word_name;
			public MySQL.Field release_site_id;
			public MySQL.Field ranking;
			public MySQL.Field position;
			public MySQL.Field url;
			public MySQL.Field search_type;
			public MySQL.Field is_release_site_data;
			public MySQL.Field is_platform;
			public MySQL.Field count;
			public MySQL.Field overall_count;
			public MySQL.Field html_url;
			public MySQL.Field label_type;
			public MySQL.Field label_attribute_type;
			public MySQL.Field label_attribute_value;
			public MySQL.Field label_position;
			public MySQL.Field datetime;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field is_erased;

			public t_m_kw_search_count()
			{
				TableName = "t_m_kw_search_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_trolley_id = new MySQL.Field(this, "key_trolley_id", "key_trolley_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				is_release_site_data = new MySQL.Field(this, "is_release_site_data", "is_release_site_data", MySqlDbType.Bit, false);
				is_platform = new MySQL.Field(this, "is_platform", "is_platform", MySqlDbType.Bit, false);
				count = new MySQL.Field(this, "count", "count", MySqlDbType.Int32, false);
				overall_count = new MySQL.Field(this, "overall_count", "overall_count", MySqlDbType.Int32, false);
				html_url = new MySQL.Field(this, "html_url", "html_url", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_attribute_type = new MySQL.Field(this, "label_attribute_type", "label_attribute_type", MySqlDbType.VarChar, false);
				label_attribute_value = new MySQL.Field(this, "label_attribute_value", "label_attribute_value", MySqlDbType.VarChar, false);
				label_position = new MySQL.Field(this, "label_position", "label_position", MySqlDbType.VarChar, false);
				datetime = new MySQL.Field(this, "datetime", "datetime", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_count_2016 : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_trolley_id;
			public MySQL.Field key_word_name;
			public MySQL.Field release_site_id;
			public MySQL.Field ranking;
			public MySQL.Field position;
			public MySQL.Field url;
			public MySQL.Field search_type;
			public MySQL.Field is_release_site_data;
			public MySQL.Field is_platform;
			public MySQL.Field count;
			public MySQL.Field overall_count;
			public MySQL.Field html_url;
			public MySQL.Field label_type;
			public MySQL.Field label_attribute_type;
			public MySQL.Field label_attribute_value;
			public MySQL.Field label_position;
			public MySQL.Field datetime;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field is_erased;

			public t_m_kw_search_count_2016()
			{
				TableName = "t_m_kw_search_count_2016";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_trolley_id = new MySQL.Field(this, "key_trolley_id", "key_trolley_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				is_release_site_data = new MySQL.Field(this, "is_release_site_data", "is_release_site_data", MySqlDbType.Bit, false);
				is_platform = new MySQL.Field(this, "is_platform", "is_platform", MySqlDbType.Bit, false);
				count = new MySQL.Field(this, "count", "count", MySqlDbType.Int32, false);
				overall_count = new MySQL.Field(this, "overall_count", "overall_count", MySqlDbType.Int32, false);
				html_url = new MySQL.Field(this, "html_url", "html_url", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_attribute_type = new MySQL.Field(this, "label_attribute_type", "label_attribute_type", MySqlDbType.VarChar, false);
				label_attribute_value = new MySQL.Field(this, "label_attribute_value", "label_attribute_value", MySqlDbType.VarChar, false);
				label_position = new MySQL.Field(this, "label_position", "label_position", MySqlDbType.VarChar, false);
				datetime = new MySQL.Field(this, "datetime", "datetime", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field keyword;
			public MySQL.Field search_count_id;
			public MySQL.Field ip;
			public MySQL.Field create_time;
			public MySQL.Field product_id;
			public MySQL.Field search_type;
			public MySQL.Field has_ranking;

			public t_m_kw_search_log()
			{
				TableName = "t_m_kw_search_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				search_count_id = new MySQL.Field(this, "search_count_id", "search_count_id", MySqlDbType.Int64, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int32, false);
				has_ranking = new MySQL.Field(this, "has_ranking", "has_ranking", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field key_trolley_id;
			public MySQL.Field key_word_name;
			public MySQL.Field site_url;
			public MySQL.Field company_name;
			public MySQL.Field company_short_name;
			public MySQL.Field product_id;
			public MySQL.Field trademark;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field search_type;
			public MySQL.Field type;

			public t_m_kw_search_release()
			{
				TableName = "t_m_kw_search_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				key_trolley_id = new MySQL.Field(this, "key_trolley_id", "key_trolley_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				site_url = new MySQL.Field(this, "site_url", "site_url", MySqlDbType.VarChar, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				company_short_name = new MySQL.Field(this, "company_short_name", "company_short_name", MySqlDbType.VarChar, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				trademark = new MySQL.Field(this, "trademark", "trademark", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_release_copy : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field key_trolley_id;
			public MySQL.Field key_word_name;
			public MySQL.Field site_url;
			public MySQL.Field company_name;
			public MySQL.Field company_short_name;
			public MySQL.Field product_id;
			public MySQL.Field trademark;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field search_type;
			public MySQL.Field type;

			public t_m_kw_search_release_copy()
			{
				TableName = "t_m_kw_search_release_copy";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				key_trolley_id = new MySQL.Field(this, "key_trolley_id", "key_trolley_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				site_url = new MySQL.Field(this, "site_url", "site_url", MySqlDbType.VarChar, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				company_short_name = new MySQL.Field(this, "company_short_name", "company_short_name", MySqlDbType.VarChar, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				trademark = new MySQL.Field(this, "trademark", "trademark", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_search_week : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field is_erased;

			public t_m_kw_search_week()
			{
				TableName = "t_m_kw_search_week";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_trolley : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field name;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_m_kw_trolley()
			{
				TableName = "t_m_kw_trolley";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_trolley_money : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field kw_trolley_id;
			public MySQL.Field search_type;
			public MySQL.Field page_type;
			public MySQL.Field money;
			public MySQL.Field is_erased;

			public t_m_kw_trolley_money()
			{
				TableName = "t_m_kw_trolley_money";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				kw_trolley_id = new MySQL.Field(this, "kw_trolley_id", "kw_trolley_id", MySqlDbType.Int64, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_ul_exponential : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field kw_user_lexicon;
			public MySQL.Field lxponential;
			public MySQL.Field l_exponential_url;
			public MySQL.Field included_quantity;
			public MySQL.Field included_quantity_url;
			public MySQL.Field index_web;
			public MySQL.Field index_number;
			public MySQL.Field evaluate;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_kw_ul_exponential()
			{
				TableName = "t_m_kw_ul_exponential";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				kw_user_lexicon = new MySQL.Field(this, "kw_user_lexicon", "kw_user_lexicon", MySqlDbType.Int64, false);
				lxponential = new MySQL.Field(this, "lxponential", "lxponential", MySqlDbType.Int32, false);
				l_exponential_url = new MySQL.Field(this, "l_exponential_url", "l_exponential_url", MySqlDbType.VarChar, false);
				included_quantity = new MySQL.Field(this, "included_quantity", "included_quantity", MySqlDbType.Int32, false);
				included_quantity_url = new MySQL.Field(this, "included_quantity_url", "included_quantity_url", MySqlDbType.VarChar, false);
				index_web = new MySQL.Field(this, "index_web", "index_web", MySqlDbType.Int32, false);
				index_number = new MySQL.Field(this, "index_number", "index_number", MySqlDbType.Int32, false);
				evaluate = new MySQL.Field(this, "evaluate", "evaluate", MySqlDbType.Int32, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_kw_user_lexicon : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field name;
			public MySQL.Field md5_name;
			public MySQL.Field is_need;
			public MySQL.Field state;
			public MySQL.Field is_shield;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field is_erased;

			public t_m_kw_user_lexicon()
			{
				TableName = "t_m_kw_user_lexicon";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				md5_name = new MySQL.Field(this, "md5_name", "md5_name", MySqlDbType.VarChar, false);
				is_need = new MySQL.Field(this, "is_need", "is_need", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_shield = new MySQL.Field(this, "is_shield", "is_shield", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_leng_keyword : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_id;
			public MySQL.Field name;
			public MySQL.Field trolley_id;
			public MySQL.Field is_select;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field key_word_type;

			public t_m_leng_keyword()
			{
				TableName = "t_m_leng_keyword";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				trolley_id = new MySQL.Field(this, "trolley_id", "trolley_id", MySqlDbType.Int64, false);
				is_select = new MySQL.Field(this, "is_select", "is_select", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				key_word_type = new MySQL.Field(this, "key_word_type", "key_word_type", MySqlDbType.Int32, false);
			}
		}

		public class t_m_leng_keyword_temporary : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field longKeyJson;
			public MySQL.Field release_id;
			public MySQL.Field create_date;
			public MySQL.Field is_erased;

			public t_m_leng_keyword_temporary()
			{
				TableName = "t_m_leng_keyword_temporary";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				longKeyJson = new MySQL.Field(this, "longKeyJson", "longKeyJson", MySqlDbType.MediumText, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int32, false);
				create_date = new MySQL.Field(this, "create_date", "create_date", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_no_money_install : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field page_type;
			public MySQL.Field day;
			public MySQL.Field create_time;

			public t_m_no_money_install()
			{
				TableName = "t_m_no_money_install";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_no_money_kw : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field kw_trolley_id;
			public MySQL.Field ranking;
			public MySQL.Field money;
			public MySQL.Field day;
			public MySQL.Field search_type;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field is_long;

			public t_m_no_money_kw()
			{
				TableName = "t_m_no_money_kw";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				kw_trolley_id = new MySQL.Field(this, "kw_trolley_id", "kw_trolley_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.Int32, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_long = new MySQL.Field(this, "is_long", "is_long", MySqlDbType.Bit, false);
			}
		}

		public class t_m_offer_concrete : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field discount1;
			public MySQL.Field discount2;
			public MySQL.Field begin_number;
			public MySQL.Field end_number;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_offer_concrete()
			{
				TableName = "t_m_offer_concrete";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				discount1 = new MySQL.Field(this, "discount1", "discount1", MySqlDbType.Decimal, false);
				discount2 = new MySQL.Field(this, "discount2", "discount2", MySqlDbType.Decimal, false);
				begin_number = new MySQL.Field(this, "begin_number", "begin_number", MySqlDbType.Int32, false);
				end_number = new MySQL.Field(this, "end_number", "end_number", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_offer_criterion : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field qmyr_day;
			public MySQL.Field million_day;
			public MySQL.Field home_page_number;
			public MySQL.Field home_page_discount;
			public MySQL.Field create_time;

			public t_m_offer_criterion()
			{
				TableName = "t_m_offer_criterion";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				qmyr_day = new MySQL.Field(this, "qmyr_day", "qmyr_day", MySqlDbType.Int32, false);
				million_day = new MySQL.Field(this, "million_day", "million_day", MySqlDbType.Int32, false);
				home_page_number = new MySQL.Field(this, "home_page_number", "home_page_number", MySqlDbType.Int32, false);
				home_page_discount = new MySQL.Field(this, "home_page_discount", "home_page_discount", MySqlDbType.Decimal, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_offer_other : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field search_type;
			public MySQL.Field page_type;
			public MySQL.Field discount;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_offer_other()
			{
				TableName = "t_m_offer_other";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				page_type = new MySQL.Field(this, "page_type", "page_type", MySqlDbType.Int24, false);
				discount = new MySQL.Field(this, "discount", "discount", MySqlDbType.Decimal, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_pay_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field img_path;
			public MySQL.Field is_erased;

			public t_m_pay_type()
			{
				TableName = "t_m_pay_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				img_path = new MySQL.Field(this, "img_path", "img_path", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_recharge : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field recharge_record_id;
			public MySQL.Field money;
			public MySQL.Field p_type;
			public MySQL.Field state;
			public MySQL.Field odd_numbers;
			public MySQL.Field remark;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_m_recharge()
			{
				TableName = "t_m_recharge";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				recharge_record_id = new MySQL.Field(this, "recharge_record_id", "recharge_record_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				p_type = new MySQL.Field(this, "p_type", "p_type", MySqlDbType.Int32, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Bit, false);
				odd_numbers = new MySQL.Field(this, "odd_numbers", "odd_numbers", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_recharge_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field money;
			public MySQL.Field m_type;
			public MySQL.Field state;
			public MySQL.Field ordered;
			public MySQL.Field md5;
			public MySQL.Field create_time;
			public MySQL.Field type;
			public MySQL.Field is_erased;

			public t_m_recharge_record()
			{
				TableName = "t_m_recharge_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				m_type = new MySQL.Field(this, "m_type", "m_type", MySqlDbType.Int32, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				ordered = new MySQL.Field(this, "ordered", "ordered", MySqlDbType.VarChar, false);
				md5 = new MySQL.Field(this, "md5", "md5", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_refundment : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field balance;
			public MySQL.Field money;
			public MySQL.Field poundage;
			public MySQL.Field p_type;
			public MySQL.Field open_bank;
			public MySQL.Field account_number;
			public MySQL.Field name;
			public MySQL.Field remark;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field auditing_time;
			public MySQL.Field pay_time;
			public MySQL.Field pay_succeed_time;
			public MySQL.Field serial_number;
			public MySQL.Field r_o_id;
			public MySQL.Field is_erased;

			public t_m_refundment()
			{
				TableName = "t_m_refundment";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				balance = new MySQL.Field(this, "balance", "balance", MySqlDbType.Decimal, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				poundage = new MySQL.Field(this, "poundage", "poundage", MySqlDbType.Decimal, false);
				p_type = new MySQL.Field(this, "p_type", "p_type", MySqlDbType.Int32, false);
				open_bank = new MySQL.Field(this, "open_bank", "open_bank", MySqlDbType.VarChar, false);
				account_number = new MySQL.Field(this, "account_number", "account_number", MySqlDbType.VarChar, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				auditing_time = new MySQL.Field(this, "auditing_time", "auditing_time", MySqlDbType.DateTime, false);
				pay_time = new MySQL.Field(this, "pay_time", "pay_time", MySqlDbType.DateTime, false);
				pay_succeed_time = new MySQL.Field(this, "pay_succeed_time", "pay_succeed_time", MySqlDbType.DateTime, false);
				serial_number = new MySQL.Field(this, "serial_number", "serial_number", MySqlDbType.VarChar, false);
				r_o_id = new MySQL.Field(this, "r_o_id", "r_o_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_refundment_operate : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field serial_number;
			public MySQL.Field sum_money;
			public MySQL.Field man_number;
			public MySQL.Field poundage;
			public MySQL.Field detail;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field payment_time;
			public MySQL.Field is_erased;

			public t_m_refundment_operate()
			{
				TableName = "t_m_refundment_operate";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				serial_number = new MySQL.Field(this, "serial_number", "serial_number", MySqlDbType.VarChar, false);
				sum_money = new MySQL.Field(this, "sum_money", "sum_money", MySqlDbType.Decimal, false);
				man_number = new MySQL.Field(this, "man_number", "man_number", MySqlDbType.Int32, false);
				poundage = new MySQL.Field(this, "poundage", "poundage", MySqlDbType.Decimal, false);
				detail = new MySQL.Field(this, "detail", "detail", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				payment_time = new MySQL.Field(this, "payment_time", "payment_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_refundment_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field refundment_id;
			public MySQL.Field user_id;
			public MySQL.Field money;
			public MySQL.Field m_type;
			public MySQL.Field state;
			public MySQL.Field md5;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_refundment_record()
			{
				TableName = "t_m_refundment_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				refundment_id = new MySQL.Field(this, "refundment_id", "refundment_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				m_type = new MySQL.Field(this, "m_type", "m_type", MySqlDbType.Int32, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				md5 = new MySQL.Field(this, "md5", "md5", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_remind : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field name;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_remind()
			{
				TableName = "t_m_remind";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_rs_arrearage : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_site_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_m_rs_arrearage()
			{
				TableName = "t_m_rs_arrearage";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_m_rs_no_money : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field site_id;
			public MySQL.Field create_time;

			public t_m_rs_no_money()
			{
				TableName = "t_m_rs_no_money";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_m_service_charge : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_id;
			public MySQL.Field money;
			public MySQL.Field create_time;
			public MySQL.Field end_time;
			public MySQL.Field is_erased;

			public t_m_service_charge()
			{
				TableName = "t_m_service_charge";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				end_time = new MySQL.Field(this, "end_time", "end_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_provinces : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field data_version;

			public t_provinces()
			{
				TableName = "t_provinces";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				data_version = new MySQL.Field(this, "data_version", "data_version", MySqlDbType.Int64, false);
			}
		}

		public class t_proxy_ip : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field ip;
			public MySQL.Field port;
			public MySQL.Field area;
			public MySQL.Field anonymous;
			public MySQL.Field create_time;
			public MySQL.Field type;
			public MySQL.Field is_erased;

			public t_proxy_ip()
			{
				TableName = "t_proxy_ip";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				port = new MySQL.Field(this, "port", "port", MySqlDbType.VarChar, false);
				area = new MySQL.Field(this, "area", "area", MySqlDbType.VarChar, false);
				anonymous = new MySQL.Field(this, "anonymous", "anonymous", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_publish_rsite_grade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field grade_name;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_publish_rsite_grade()
			{
				TableName = "t_publish_rsite_grade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				grade_name = new MySQL.Field(this, "grade_name", "grade_name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_publish_rsite_rule : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field publish_grade_id;
			public MySQL.Field release_grade;
			public MySQL.Field release_select_number;
			public MySQL.Field release_number;
			public MySQL.Field thread_time_type;

			public t_publish_rsite_rule()
			{
				TableName = "t_publish_rsite_rule";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				publish_grade_id = new MySQL.Field(this, "publish_grade_id", "publish_grade_id", MySqlDbType.Int32, false);
				release_grade = new MySQL.Field(this, "release_grade", "release_grade", MySqlDbType.VarChar, false);
				release_select_number = new MySQL.Field(this, "release_select_number", "release_select_number", MySqlDbType.Int32, false);
				release_number = new MySQL.Field(this, "release_number", "release_number", MySqlDbType.Int32, false);
				thread_time_type = new MySQL.Field(this, "thread_time_type", "thread_time_type", MySqlDbType.Int24, false);
			}
		}

		public class t_publish_thread_intercalate : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field thread_time_type;
			public MySQL.Field publish_product_number;
			public MySQL.Field client_publish_number;
			public MySQL.Field create_time;
			public MySQL.Field update_time;

			public t_publish_thread_intercalate()
			{
				TableName = "t_publish_thread_intercalate";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				thread_time_type = new MySQL.Field(this, "thread_time_type", "thread_time_type", MySqlDbType.Int24, false);
				publish_product_number = new MySQL.Field(this, "publish_product_number", "publish_product_number", MySqlDbType.Int32, false);
				client_publish_number = new MySQL.Field(this, "client_publish_number", "client_publish_number", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
			}
		}

		public class t_ranking_error : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field keyword;
			public MySQL.Field message;
			public MySQL.Field ip;
			public MySQL.Field track;
			public MySQL.Field create_time;
			public MySQL.Field release_site_url;
			public MySQL.Field search_type;
			public MySQL.Field is_short;

			public t_ranking_error()
			{
				TableName = "t_ranking_error";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				message = new MySQL.Field(this, "message", "message", MySqlDbType.VarChar, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				track = new MySQL.Field(this, "track", "track", MySqlDbType.Text, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				release_site_url = new MySQL.Field(this, "release_site_url", "release_site_url", MySqlDbType.Text, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int32, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Bit, false);
			}
		}

		public class t_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field url;
			public MySQL.Field remark;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;
			public MySQL.Field order_id;
			public MySQL.Field is_system;
			public MySQL.Field weight;
			public MySQL.Field state;
			public MySQL.Field is_message;
			public MySQL.Field is_ie;
			public MySQL.Field grade;
			public MySQL.Field trade_name;
			public MySQL.Field is_register;
			public MySQL.Field regist_audit_time;
			public MySQL.Field regist_ip_time;
			public MySQL.Field base_audit_time;
			public MySQL.Field login_ip_time;

			public t_release()
			{
				TableName = "t_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
				is_system = new MySQL.Field(this, "is_system", "is_system", MySqlDbType.Bit, false);
				weight = new MySQL.Field(this, "weight", "weight", MySqlDbType.Int64, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_message = new MySQL.Field(this, "is_message", "is_message", MySqlDbType.Bit, false);
				is_ie = new MySQL.Field(this, "is_ie", "is_ie", MySqlDbType.Bit, false);
				grade = new MySQL.Field(this, "grade", "grade", MySqlDbType.VarChar, false);
				trade_name = new MySQL.Field(this, "trade_name", "trade_name", MySqlDbType.VarChar, false);
				is_register = new MySQL.Field(this, "is_register", "is_register", MySqlDbType.Bit, false);
				regist_audit_time = new MySQL.Field(this, "regist_audit_time", "regist_audit_time", MySqlDbType.Int16, false);
				regist_ip_time = new MySQL.Field(this, "regist_ip_time", "regist_ip_time", MySqlDbType.Int32, false);
				base_audit_time = new MySQL.Field(this, "base_audit_time", "base_audit_time", MySqlDbType.Int16, false);
				login_ip_time = new MySQL.Field(this, "login_ip_time", "login_ip_time", MySqlDbType.Int32, false);
			}
		}

		public class t_release_black_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field create_time;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field type_flag;
			public MySQL.Field is_erased;
			public MySQL.Field type_id;
			public MySQL.Field remark;

			public t_release_black_list()
			{
				TableName = "t_release_black_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.Int32, false);
				type_flag = new MySQL.Field(this, "type_flag", "type_flag", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int32, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
			}
		}

		public class t_release_black_list_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field type;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_release_black_list_type()
			{
				TableName = "t_release_black_list_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_email : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field uesr_name;
			public MySQL.Field user_password;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field is_use;
			public MySQL.Field ask;
			public MySQL.Field answer;
			public MySQL.Field answer_email;
			public MySQL.Field email_type;
			public MySQL.Field option_time;
			public MySQL.Field state;

			public t_release_email()
			{
				TableName = "t_release_email";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				uesr_name = new MySQL.Field(this, "uesr_name", "uesr_name", MySqlDbType.VarChar, false);
				user_password = new MySQL.Field(this, "user_password", "user_password", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_use = new MySQL.Field(this, "is_use", "is_use", MySqlDbType.Bit, false);
				ask = new MySQL.Field(this, "ask", "ask", MySqlDbType.VarChar, false);
				answer = new MySQL.Field(this, "answer", "answer", MySqlDbType.VarChar, false);
				answer_email = new MySQL.Field(this, "answer_email", "answer_email", MySqlDbType.VarChar, false);
				email_type = new MySQL.Field(this, "email_type", "email_type", MySqlDbType.Int64, false);
				option_time = new MySQL.Field(this, "option_time", "option_time", MySqlDbType.Timestamp, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
			}
		}

		public class t_release_email_code : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field release_email_id;
			public MySQL.Field release_id;
			public MySQL.Field code;
			public MySQL.Field state;

			public t_release_email_code()
			{
				TableName = "t_release_email_code";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				release_email_id = new MySQL.Field(this, "release_email_id", "release_email_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				code = new MySQL.Field(this, "code", "code", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int32, false);
			}
		}

		public class t_release_email_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field record_time;

			public t_release_email_record()
			{
				TableName = "t_release_email_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				record_time = new MySQL.Field(this, "record_time", "record_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_release_email_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field mail_suffix;
			public MySQL.Field register_url;
			public MySQL.Field login_url;
			public MySQL.Field is_erased;

			public t_release_email_type()
			{
				TableName = "t_release_email_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				mail_suffix = new MySQL.Field(this, "mail_suffix", "mail_suffix", MySqlDbType.VarChar, false);
				register_url = new MySQL.Field(this, "register_url", "register_url", MySqlDbType.VarChar, false);
				login_url = new MySQL.Field(this, "login_url", "login_url", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field type_id;
			public MySQL.Field type_url;
			public MySQL.Field post_url;
			public MySQL.Field user_center_url;
			public MySQL.Field is_skip;
			public MySQL.Field success_url;
			public MySQL.Field success_keyword;
			public MySQL.Field fail_url;
			public MySQL.Field fail_keyword;
			public MySQL.Field is_erased;
			public MySQL.Field is_ie;
			public MySQL.Field sensitive_w;
			public MySQL.Field interval_minute;
			public MySQL.Field create_time;
			public MySQL.Field max_num;
			public MySQL.Field order_index;

			public t_release_list()
			{
				TableName = "t_release_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int24, false);
				type_url = new MySQL.Field(this, "type_url", "type_url", MySqlDbType.VarChar, false);
				post_url = new MySQL.Field(this, "post_url", "post_url", MySqlDbType.VarChar, false);
				user_center_url = new MySQL.Field(this, "user_center_url", "user_center_url", MySqlDbType.VarChar, false);
				is_skip = new MySQL.Field(this, "is_skip", "is_skip", MySqlDbType.Bit, false);
				success_url = new MySQL.Field(this, "success_url", "success_url", MySqlDbType.VarChar, false);
				success_keyword = new MySQL.Field(this, "success_keyword", "success_keyword", MySqlDbType.VarChar, false);
				fail_url = new MySQL.Field(this, "fail_url", "fail_url", MySqlDbType.VarChar, false);
				fail_keyword = new MySQL.Field(this, "fail_keyword", "fail_keyword", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_ie = new MySQL.Field(this, "is_ie", "is_ie", MySqlDbType.Bit, false);
				sensitive_w = new MySQL.Field(this, "sensitive_w", "sensitive_w", MySqlDbType.VarChar, false);
				interval_minute = new MySQL.Field(this, "interval_minute", "interval_minute", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				max_num = new MySQL.Field(this, "max_num", "max_num", MySqlDbType.Int32, false);
				order_index = new MySQL.Field(this, "order_index", "order_index", MySqlDbType.Int24, false);
			}
		}

		public class t_release_mark : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field word_id;
			public MySQL.Field field_id;
			public MySQL.Field release_list_id;
			public MySQL.Field is_erased;
			public MySQL.Field order_id;
			public MySQL.Field word_type_id;

			public t_release_mark()
			{
				TableName = "t_release_mark";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
				word_type_id = new MySQL.Field(this, "word_type_id", "word_type_id", MySqlDbType.Int64, false);
			}
		}

		public class t_release_site_email : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field state;

			public t_release_site_email()
			{
				TableName = "t_release_site_email";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
			}
		}

		public class t_release_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field trade_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_release_trade()
			{
				TableName = "t_release_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_user : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field release_id;
			public MySQL.Field is_release;
			public MySQL.Field user_name;
			public MySQL.Field user_password;
			public MySQL.Field release_eamil_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field site_id;
			public MySQL.Field is_check_email;
			public MySQL.Field remark;

			public t_release_user()
			{
				TableName = "t_release_user";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				is_release = new MySQL.Field(this, "is_release", "is_release", MySqlDbType.Bit, false);
				user_name = new MySQL.Field(this, "user_name", "user_name", MySqlDbType.VarChar, false);
				user_password = new MySQL.Field(this, "user_password", "user_password", MySqlDbType.VarChar, false);
				release_eamil_id = new MySQL.Field(this, "release_eamil_id", "release_eamil_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				is_check_email = new MySQL.Field(this, "is_check_email", "is_check_email", MySqlDbType.Bit, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
			}
		}

		public class t_release_user_client : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field eims_id;
			public MySQL.Field eims_ip;
			public MySQL.Field preview_release_id;
			public MySQL.Field create_time;

			public t_release_user_client()
			{
				TableName = "t_release_user_client";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.VarChar, false);
				eims_ip = new MySQL.Field(this, "eims_ip", "eims_ip", MySqlDbType.VarChar, false);
				preview_release_id = new MySQL.Field(this, "preview_release_id", "preview_release_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_release_user_datum : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field type_id;
			public MySQL.Field state;

			public t_release_user_datum()
			{
				TableName = "t_release_user_datum";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int24, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
			}
		}

		public class t_release_user_preview_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field record_time;

			public t_release_user_preview_record()
			{
				TableName = "t_release_user_preview_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				record_time = new MySQL.Field(this, "record_time", "record_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_release_user_preview_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field create_time;
			public MySQL.Field state;
			public MySQL.Field pull_time;
			public MySQL.Field is_ie;

			public t_release_user_preview_release()
			{
				TableName = "t_release_user_preview_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				is_ie = new MySQL.Field(this, "is_ie", "is_ie", MySqlDbType.Bit, false);
			}
		}

		public class t_release_user_release_success : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field release_time;

			public t_release_user_release_success()
			{
				TableName = "t_release_user_release_success";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				release_time = new MySQL.Field(this, "release_time", "release_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_release_user_unregistered : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field user_id;
			public MySQL.Field site_id;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field is_ie;

			public t_release_user_unregistered()
			{
				TableName = "t_release_user_unregistered";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				is_ie = new MySQL.Field(this, "is_ie", "is_ie", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field is_required;
			public MySQL.Field word_type;
			public MySQL.Field select_value;
			public MySQL.Field value;
			public MySQL.Field order_id;
			public MySQL.Field display;
			public MySQL.Field field_id;
			public MySQL.Field level;
			public MySQL.Field condition;
			public MySQL.Field is_iframe;
			public MySQL.Field is_erased;

			public t_release_word()
			{
				TableName = "t_release_word";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				is_required = new MySQL.Field(this, "is_required", "is_required", MySqlDbType.Bit, false);
				word_type = new MySQL.Field(this, "word_type", "word_type", MySqlDbType.Int24, false);
				select_value = new MySQL.Field(this, "select_value", "select_value", MySqlDbType.VarChar, false);
				value = new MySQL.Field(this, "value", "value", MySqlDbType.VarChar, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int32, false);
				display = new MySQL.Field(this, "display", "display", MySqlDbType.VarChar, false);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				level = new MySQL.Field(this, "level", "level", MySqlDbType.Int32, false);
				condition = new MySQL.Field(this, "condition", "condition", MySqlDbType.Int32, false);
				is_iframe = new MySQL.Field(this, "is_iframe", "is_iframe", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_button : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field is_submit;
			public MySQL.Field label;
			public MySQL.Field label_type;
			public MySQL.Field label_id;
			public MySQL.Field label_name;
			public MySQL.Field label_class;
			public MySQL.Field other_attributes;
			public MySQL.Field is_delay;
			public MySQL.Field is_skip;
			public MySQL.Field position;
			public MySQL.Field iframe_position;
			public MySQL.Field is_position;
			public MySQL.Field execute_js;
			public MySQL.Field alert_label_id;
			public MySQL.Field is_submit_many_click;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;
			public MySQL.Field xy_coordinate;
			public MySQL.Field is_erased;

			public t_release_word_button()
			{
				TableName = "t_release_word_button";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				is_submit = new MySQL.Field(this, "is_submit", "is_submit", MySqlDbType.Bit, false);
				label = new MySQL.Field(this, "label", "label", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_id = new MySQL.Field(this, "label_id", "label_id", MySqlDbType.VarChar, false);
				label_name = new MySQL.Field(this, "label_name", "label_name", MySqlDbType.VarChar, false);
				label_class = new MySQL.Field(this, "label_class", "label_class", MySqlDbType.VarChar, false);
				other_attributes = new MySQL.Field(this, "other_attributes", "other_attributes", MySqlDbType.VarChar, false);
				is_delay = new MySQL.Field(this, "is_delay", "is_delay", MySqlDbType.Bit, false);
				is_skip = new MySQL.Field(this, "is_skip", "is_skip", MySqlDbType.Bit, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				iframe_position = new MySQL.Field(this, "iframe_position", "iframe_position", MySqlDbType.Int32, false);
				is_position = new MySQL.Field(this, "is_position", "is_position", MySqlDbType.Bit, false);
				execute_js = new MySQL.Field(this, "execute_js", "execute_js", MySqlDbType.VarChar, false);
				alert_label_id = new MySQL.Field(this, "alert_label_id", "alert_label_id", MySqlDbType.VarChar, false);
				is_submit_many_click = new MySQL.Field(this, "is_submit_many_click", "is_submit_many_click", MySqlDbType.Bit, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
				xy_coordinate = new MySQL.Field(this, "xy_coordinate", "xy_coordinate", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_identifying_code : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field img_label;
			public MySQL.Field img_label_type;
			public MySQL.Field img_label_id;
			public MySQL.Field img_label_name;
			public MySQL.Field img_label_class;
			public MySQL.Field img_other_attributes;
			public MySQL.Field img_position;
			public MySQL.Field import_label;
			public MySQL.Field import_label_type;
			public MySQL.Field import_label_id;
			public MySQL.Field import_label_name;
			public MySQL.Field import_label_class;
			public MySQL.Field import_other_attributes;
			public MySQL.Field import_position;
			public MySQL.Field is_img_iframe;
			public MySQL.Field is_import_iframe;
			public MySQL.Field is_click_import;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;
			public MySQL.Field is_input_many;
			public MySQL.Field is_touch;
			public MySQL.Field is_drag;
			public MySQL.Field is_erased;

			public t_release_word_identifying_code()
			{
				TableName = "t_release_word_identifying_code";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				img_label = new MySQL.Field(this, "img_label", "img_label", MySqlDbType.VarChar, false);
				img_label_type = new MySQL.Field(this, "img_label_type", "img_label_type", MySqlDbType.VarChar, false);
				img_label_id = new MySQL.Field(this, "img_label_id", "img_label_id", MySqlDbType.VarChar, false);
				img_label_name = new MySQL.Field(this, "img_label_name", "img_label_name", MySqlDbType.VarChar, false);
				img_label_class = new MySQL.Field(this, "img_label_class", "img_label_class", MySqlDbType.VarChar, false);
				img_other_attributes = new MySQL.Field(this, "img_other_attributes", "img_other_attributes", MySqlDbType.VarChar, false);
				img_position = new MySQL.Field(this, "img_position", "img_position", MySqlDbType.Int32, false);
				import_label = new MySQL.Field(this, "import_label", "import_label", MySqlDbType.VarChar, false);
				import_label_type = new MySQL.Field(this, "import_label_type", "import_label_type", MySqlDbType.VarChar, false);
				import_label_id = new MySQL.Field(this, "import_label_id", "import_label_id", MySqlDbType.VarChar, false);
				import_label_name = new MySQL.Field(this, "import_label_name", "import_label_name", MySqlDbType.VarChar, false);
				import_label_class = new MySQL.Field(this, "import_label_class", "import_label_class", MySqlDbType.VarChar, false);
				import_other_attributes = new MySQL.Field(this, "import_other_attributes", "import_other_attributes", MySqlDbType.VarChar, false);
				import_position = new MySQL.Field(this, "import_position", "import_position", MySqlDbType.Int32, false);
				is_img_iframe = new MySQL.Field(this, "is_img_iframe", "is_img_iframe", MySqlDbType.Bit, false);
				is_import_iframe = new MySQL.Field(this, "is_import_iframe", "is_import_iframe", MySqlDbType.Bit, false);
				is_click_import = new MySQL.Field(this, "is_click_import", "is_click_import", MySqlDbType.Bit, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
				is_input_many = new MySQL.Field(this, "is_input_many", "is_input_many", MySqlDbType.Bit, false);
				is_touch = new MySQL.Field(this, "is_touch", "is_touch", MySqlDbType.Bit, false);
				is_drag = new MySQL.Field(this, "is_drag", "is_drag", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_img : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field label;
			public MySQL.Field label_type;
			public MySQL.Field label_id;
			public MySQL.Field label_name;
			public MySQL.Field label_class;
			public MySQL.Field other_attributes;
			public MySQL.Field son_label;
			public MySQL.Field son_label_type;
			public MySQL.Field son_label_id;
			public MySQL.Field son_label_name;
			public MySQL.Field son_label_class;
			public MySQL.Field son_other_attributes;
			public MySQL.Field is_flash;
			public MySQL.Field son_position;
			public MySQL.Field position;
			public MySQL.Field img_kb;
			public MySQL.Field is_erased;
			public MySQL.Field width_height;
			public MySQL.Field flash_xy;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;
			public MySQL.Field picture_format;

			public t_release_word_img()
			{
				TableName = "t_release_word_img";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				label = new MySQL.Field(this, "label", "label", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_id = new MySQL.Field(this, "label_id", "label_id", MySqlDbType.VarChar, false);
				label_name = new MySQL.Field(this, "label_name", "label_name", MySqlDbType.VarChar, false);
				label_class = new MySQL.Field(this, "label_class", "label_class", MySqlDbType.VarChar, false);
				other_attributes = new MySQL.Field(this, "other_attributes", "other_attributes", MySqlDbType.VarChar, false);
				son_label = new MySQL.Field(this, "son_label", "son_label", MySqlDbType.VarChar, false);
				son_label_type = new MySQL.Field(this, "son_label_type", "son_label_type", MySqlDbType.VarChar, false);
				son_label_id = new MySQL.Field(this, "son_label_id", "son_label_id", MySqlDbType.VarChar, false);
				son_label_name = new MySQL.Field(this, "son_label_name", "son_label_name", MySqlDbType.VarChar, false);
				son_label_class = new MySQL.Field(this, "son_label_class", "son_label_class", MySqlDbType.VarChar, false);
				son_other_attributes = new MySQL.Field(this, "son_other_attributes", "son_other_attributes", MySqlDbType.VarChar, false);
				is_flash = new MySQL.Field(this, "is_flash", "is_flash", MySqlDbType.Bit, false);
				son_position = new MySQL.Field(this, "son_position", "son_position", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				img_kb = new MySQL.Field(this, "img_kb", "img_kb", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				width_height = new MySQL.Field(this, "width_height", "width_height", MySqlDbType.VarChar, false);
				flash_xy = new MySQL.Field(this, "flash_xy", "flash_xy", MySqlDbType.VarChar, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
				picture_format = new MySQL.Field(this, "picture_format", "picture_format", MySqlDbType.Int24, false);
			}
		}

		public class t_release_word_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field level;
			public MySQL.Field word_id;
			public MySQL.Field html_id;
			public MySQL.Field html_name;
			public MySQL.Field html_type;

			public t_release_word_list()
			{
				TableName = "t_release_word_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				level = new MySQL.Field(this, "level", "level", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				html_id = new MySQL.Field(this, "html_id", "html_id", MySqlDbType.VarChar, false);
				html_name = new MySQL.Field(this, "html_name", "html_name", MySqlDbType.VarChar, false);
				html_type = new MySQL.Field(this, "html_type", "html_type", MySqlDbType.Int64, false);
			}
		}

		public class t_release_word_message : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field button_label;
			public MySQL.Field button_label_type;
			public MySQL.Field button_label_id;
			public MySQL.Field button_label_name;
			public MySQL.Field button_label_class;
			public MySQL.Field button_other_attributes;
			public MySQL.Field import_label;
			public MySQL.Field import_label_type;
			public MySQL.Field import_label_id;
			public MySQL.Field import_label_name;
			public MySQL.Field import_label_class;
			public MySQL.Field import_other_attributes;
			public MySQL.Field position;
			public MySQL.Field son_position;
			public MySQL.Field is_button_iframe;
			public MySQL.Field is_import_iframe;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;
			public MySQL.Field is_email_code;
			public MySQL.Field is_erased;

			public t_release_word_message()
			{
				TableName = "t_release_word_message";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				button_label = new MySQL.Field(this, "button_label", "button_label", MySqlDbType.VarChar, false);
				button_label_type = new MySQL.Field(this, "button_label_type", "button_label_type", MySqlDbType.VarChar, false);
				button_label_id = new MySQL.Field(this, "button_label_id", "button_label_id", MySqlDbType.VarChar, false);
				button_label_name = new MySQL.Field(this, "button_label_name", "button_label_name", MySqlDbType.VarChar, false);
				button_label_class = new MySQL.Field(this, "button_label_class", "button_label_class", MySqlDbType.VarChar, false);
				button_other_attributes = new MySQL.Field(this, "button_other_attributes", "button_other_attributes", MySqlDbType.VarChar, false);
				import_label = new MySQL.Field(this, "import_label", "import_label", MySqlDbType.VarChar, false);
				import_label_type = new MySQL.Field(this, "import_label_type", "import_label_type", MySqlDbType.VarChar, false);
				import_label_id = new MySQL.Field(this, "import_label_id", "import_label_id", MySqlDbType.VarChar, false);
				import_label_name = new MySQL.Field(this, "import_label_name", "import_label_name", MySqlDbType.VarChar, false);
				import_label_class = new MySQL.Field(this, "import_label_class", "import_label_class", MySqlDbType.VarChar, false);
				import_other_attributes = new MySQL.Field(this, "import_other_attributes", "import_other_attributes", MySqlDbType.VarChar, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				son_position = new MySQL.Field(this, "son_position", "son_position", MySqlDbType.Int32, false);
				is_button_iframe = new MySQL.Field(this, "is_button_iframe", "is_button_iframe", MySqlDbType.Bit, false);
				is_import_iframe = new MySQL.Field(this, "is_import_iframe", "is_import_iframe", MySqlDbType.Bit, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
				is_email_code = new MySQL.Field(this, "is_email_code", "is_email_code", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_select : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field is_pop;
			public MySQL.Field number;
			public MySQL.Field label;
			public MySQL.Field label_type;
			public MySQL.Field son_label;
			public MySQL.Field son_label_type;
			public MySQL.Field attributes_status;
			public MySQL.Field is_delay;
			public MySQL.Field is_many;
			public MySQL.Field position;
			public MySQL.Field is_erased;
			public MySQL.Field is_position;
			public MySQL.Field is_checkbox;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;

			public t_release_word_select()
			{
				TableName = "t_release_word_select";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				is_pop = new MySQL.Field(this, "is_pop", "is_pop", MySqlDbType.Bit, false);
				number = new MySQL.Field(this, "number", "number", MySqlDbType.Int32, false);
				label = new MySQL.Field(this, "label", "label", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				son_label = new MySQL.Field(this, "son_label", "son_label", MySqlDbType.VarChar, false);
				son_label_type = new MySQL.Field(this, "son_label_type", "son_label_type", MySqlDbType.VarChar, false);
				attributes_status = new MySQL.Field(this, "attributes_status", "attributes_status", MySqlDbType.Int32, false);
				is_delay = new MySQL.Field(this, "is_delay", "is_delay", MySqlDbType.Bit, false);
				is_many = new MySQL.Field(this, "is_many", "is_many", MySqlDbType.Bit, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_position = new MySQL.Field(this, "is_position", "is_position", MySqlDbType.Bit, false);
				is_checkbox = new MySQL.Field(this, "is_checkbox", "is_checkbox", MySqlDbType.Bit, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_select_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_select_id;
			public MySQL.Field label_id;
			public MySQL.Field label_name;
			public MySQL.Field label_class;
			public MySQL.Field other_attributes;
			public MySQL.Field order_id;
			public MySQL.Field is_erased;

			public t_release_word_select_list()
			{
				TableName = "t_release_word_select_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_select_id = new MySQL.Field(this, "word_select_id", "word_select_id", MySqlDbType.Int64, false);
				label_id = new MySQL.Field(this, "label_id", "label_id", MySqlDbType.VarChar, false);
				label_name = new MySQL.Field(this, "label_name", "label_name", MySqlDbType.VarChar, false);
				label_class = new MySQL.Field(this, "label_class", "label_class", MySqlDbType.VarChar, false);
				other_attributes = new MySQL.Field(this, "other_attributes", "other_attributes", MySqlDbType.VarChar, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_release_word_text : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_list_id;
			public MySQL.Field word_id;
			public MySQL.Field label;
			public MySQL.Field label_type;
			public MySQL.Field label_id;
			public MySQL.Field label_name;
			public MySQL.Field label_class;
			public MySQL.Field other_attributes;
			public MySQL.Field is_many;
			public MySQL.Field position;
			public MySQL.Field is_delay;
			public MySQL.Field length;
			public MySQL.Field is_html;
			public MySQL.Field special_character;
			public MySQL.Field style_css;
			public MySQL.Field is_http;
			public MySQL.Field is_link;
			public MySQL.Field is_contact;
			public MySQL.Field is_sensitive;
			public MySQL.Field is_click_import;
			public MySQL.Field is_pop_page;
			public MySQL.Field is_pop_page_label;
			public MySQL.Field add_text_value;
			public MySQL.Field is_erased;

			public t_release_word_text()
			{
				TableName = "t_release_word_text";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_list_id = new MySQL.Field(this, "release_list_id", "release_list_id", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				label = new MySQL.Field(this, "label", "label", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_id = new MySQL.Field(this, "label_id", "label_id", MySqlDbType.VarChar, false);
				label_name = new MySQL.Field(this, "label_name", "label_name", MySqlDbType.VarChar, false);
				label_class = new MySQL.Field(this, "label_class", "label_class", MySqlDbType.VarChar, false);
				other_attributes = new MySQL.Field(this, "other_attributes", "other_attributes", MySqlDbType.VarChar, false);
				is_many = new MySQL.Field(this, "is_many", "is_many", MySqlDbType.Bit, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				is_delay = new MySQL.Field(this, "is_delay", "is_delay", MySqlDbType.Bit, false);
				length = new MySQL.Field(this, "length", "length", MySqlDbType.Int32, false);
				is_html = new MySQL.Field(this, "is_html", "is_html", MySqlDbType.Bit, false);
				special_character = new MySQL.Field(this, "special_character", "special_character", MySqlDbType.VarChar, false);
				style_css = new MySQL.Field(this, "style_css", "style_css", MySqlDbType.VarChar, false);
				is_http = new MySQL.Field(this, "is_http", "is_http", MySqlDbType.Bit, false);
				is_link = new MySQL.Field(this, "is_link", "is_link", MySqlDbType.Bit, false);
				is_contact = new MySQL.Field(this, "is_contact", "is_contact", MySqlDbType.Bit, false);
				is_sensitive = new MySQL.Field(this, "is_sensitive", "is_sensitive", MySqlDbType.Bit, false);
				is_click_import = new MySQL.Field(this, "is_click_import", "is_click_import", MySqlDbType.Bit, false);
				is_pop_page = new MySQL.Field(this, "is_pop_page", "is_pop_page", MySqlDbType.Bit, false);
				is_pop_page_label = new MySQL.Field(this, "is_pop_page_label", "is_pop_page_label", MySqlDbType.Bit, false);
				add_text_value = new MySQL.Field(this, "add_text_value", "add_text_value", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_field : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field field_name;
			public MySQL.Field para_type_id;
			public MySQL.Field field_display;
			public MySQL.Field prefix;
			public MySQL.Field prefix_split_char;
			public MySQL.Field prefix_is_expand;
			public MySQL.Field suffix;
			public MySQL.Field suffix_split_char;
			public MySQL.Field suffix_is_expand;
			public MySQL.Field current_value;
			public MySQL.Field expand_count;
			public MySQL.Field expand_level;
			public MySQL.Field is_dynamic;
			public MySQL.Field is_dynamic_dynamic;
			public MySQL.Field is_try_edit;
			public MySQL.Field is_expand_up;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field style_id;
			public MySQL.Field position_id;
			public MySQL.Field dynamic_id;
			public MySQL.Field is_erased;
			public MySQL.Field is_key_word;
			public MySQL.Field is_site;
			public MySQL.Field is_product;
			public MySQL.Field alias;
			public MySQL.Field alias_key;
			public MySQL.Field is_word;
			public MySQL.Field is_area;
			public MySQL.Field is_long_text;

			public t_synth_field()
			{
				TableName = "t_synth_field";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				field_name = new MySQL.Field(this, "field_name", "field_name", MySqlDbType.VarChar, false);
				para_type_id = new MySQL.Field(this, "para_type_id", "para_type_id", MySqlDbType.Int64, false);
				field_display = new MySQL.Field(this, "field_display", "field_display", MySqlDbType.VarChar, false);
				prefix = new MySQL.Field(this, "prefix", "prefix", MySqlDbType.VarChar, false);
				prefix_split_char = new MySQL.Field(this, "prefix_split_char", "prefix_split_char", MySqlDbType.VarChar, false);
				prefix_is_expand = new MySQL.Field(this, "prefix_is_expand", "prefix_is_expand", MySqlDbType.Bit, false);
				suffix = new MySQL.Field(this, "suffix", "suffix", MySqlDbType.VarChar, false);
				suffix_split_char = new MySQL.Field(this, "suffix_split_char", "suffix_split_char", MySqlDbType.VarChar, false);
				suffix_is_expand = new MySQL.Field(this, "suffix_is_expand", "suffix_is_expand", MySqlDbType.Bit, false);
				current_value = new MySQL.Field(this, "current_value", "current_value", MySqlDbType.Int64, false);
				expand_count = new MySQL.Field(this, "expand_count", "expand_count", MySqlDbType.Int64, false);
				expand_level = new MySQL.Field(this, "expand_level", "expand_level", MySqlDbType.Int64, false);
				is_dynamic = new MySQL.Field(this, "is_dynamic", "is_dynamic", MySqlDbType.Bit, false);
				is_dynamic_dynamic = new MySQL.Field(this, "is_dynamic_dynamic", "is_dynamic_dynamic", MySqlDbType.Bit, false);
				is_try_edit = new MySQL.Field(this, "is_try_edit", "is_try_edit", MySqlDbType.Bit, false);
				is_expand_up = new MySQL.Field(this, "is_expand_up", "is_expand_up", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				position_id = new MySQL.Field(this, "position_id", "position_id", MySqlDbType.Int64, false);
				dynamic_id = new MySQL.Field(this, "dynamic_id", "dynamic_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				is_site = new MySQL.Field(this, "is_site", "is_site", MySqlDbType.Bit, false);
				is_product = new MySQL.Field(this, "is_product", "is_product", MySqlDbType.Bit, false);
				alias = new MySQL.Field(this, "alias", "alias", MySqlDbType.VarChar, false);
				alias_key = new MySQL.Field(this, "alias_key", "alias_key", MySqlDbType.VarChar, false);
				is_word = new MySQL.Field(this, "is_word", "is_word", MySqlDbType.Bit, false);
				is_area = new MySQL.Field(this, "is_area", "is_area", MySqlDbType.Bit, false);
				is_long_text = new MySQL.Field(this, "is_long_text", "is_long_text", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_field_alias : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field field_id;
			public MySQL.Field alias_name;

			public t_synth_field_alias()
			{
				TableName = "t_synth_field_alias";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				alias_name = new MySQL.Field(this, "alias_name", "alias_name", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_field_dynamic : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field synth_field_id;
			public MySQL.Field site_id;
			public MySQL.Field product_id;
			public MySQL.Field name;
			public MySQL.Field word_list_id;
			public MySQL.Field is_erased;
			public MySQL.Field disable_parent_trade;
			public MySQL.Field word_type;
			public MySQL.Field is_must;
			public MySQL.Field order_id;

			public t_synth_field_dynamic()
			{
				TableName = "t_synth_field_dynamic";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				synth_field_id = new MySQL.Field(this, "synth_field_id", "synth_field_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				word_list_id = new MySQL.Field(this, "word_list_id", "word_list_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				disable_parent_trade = new MySQL.Field(this, "disable_parent_trade", "disable_parent_trade", MySqlDbType.Bit, false);
				word_type = new MySQL.Field(this, "word_type", "word_type", MySqlDbType.Int64, false);
				is_must = new MySQL.Field(this, "is_must", "is_must", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_field_dynamic_copy : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field synth_field_id;
			public MySQL.Field site_id;
			public MySQL.Field product_id;
			public MySQL.Field name;
			public MySQL.Field word_list_id;
			public MySQL.Field is_erased;
			public MySQL.Field disable_parent_trade;
			public MySQL.Field word_type;
			public MySQL.Field is_must;
			public MySQL.Field order_id;

			public t_synth_field_dynamic_copy()
			{
				TableName = "t_synth_field_dynamic_copy";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				synth_field_id = new MySQL.Field(this, "synth_field_id", "synth_field_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				word_list_id = new MySQL.Field(this, "word_list_id", "word_list_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				disable_parent_trade = new MySQL.Field(this, "disable_parent_trade", "disable_parent_trade", MySqlDbType.Bit, false);
				word_type = new MySQL.Field(this, "word_type", "word_type", MySqlDbType.Int64, false);
				is_must = new MySQL.Field(this, "is_must", "is_must", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_field_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field field_id;
			public MySQL.Field type_id;

			public t_synth_field_release()
			{
				TableName = "t_synth_field_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_field_release_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field remark;

			public t_synth_field_release_type()
			{
				TableName = "t_synth_field_release_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_key_word : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field kw_trolley_id;
			public MySQL.Field name;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field product_id;
			public MySQL.Field option_user_id;
			public MySQL.Field is_short;
			public MySQL.Field type;

			public t_synth_key_word()
			{
				TableName = "t_synth_key_word";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				kw_trolley_id = new MySQL.Field(this, "kw_trolley_id", "kw_trolley_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				option_user_id = new MySQL.Field(this, "option_user_id", "option_user_id", MySqlDbType.Int64, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Bit, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_key_word_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_word_name;
			public MySQL.Field key_word_id;
			public MySQL.Field product_id;
			public MySQL.Field release_id;
			public MySQL.Field is_short;
			public MySQL.Field create_time;

			public t_synth_key_word_list()
			{
				TableName = "t_synth_key_word_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_synth_key_word_list_temporary : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field shortKeyJson;
			public MySQL.Field release_id;
			public MySQL.Field create_date;
			public MySQL.Field is_erased;

			public t_synth_key_word_list_temporary()
			{
				TableName = "t_synth_key_word_list_temporary";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				shortKeyJson = new MySQL.Field(this, "shortKeyJson", "shortKeyJson", MySqlDbType.MediumText, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int32, false);
				create_date = new MySQL.Field(this, "create_date", "create_date", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_mark : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field word_id;
			public MySQL.Field field_id;
			public MySQL.Field is_erased;
			public MySQL.Field word_type_id;
			public MySQL.Field order_id;

			public t_synth_mark()
			{
				TableName = "t_synth_mark";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				word_type_id = new MySQL.Field(this, "word_type_id", "word_type_id", MySqlDbType.Int64, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_news : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field type;
			public MySQL.Field serial_number;
			public MySQL.Field name;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_synth_news()
			{
				TableName = "t_synth_news";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int32, false);
				serial_number = new MySQL.Field(this, "serial_number", "serial_number", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_para : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field type_id;
			public MySQL.Field is_erased;

			public t_synth_para()
			{
				TableName = "t_synth_para";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_para_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field para_id;

			public t_synth_para_list()
			{
				TableName = "t_synth_para_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				para_id = new MySQL.Field(this, "para_id", "para_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_para_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field is_key_word;
			public MySQL.Field is_erased;

			public t_synth_para_type()
			{
				TableName = "t_synth_para_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_product : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field trademark;
			public MySQL.Field type_id;
			public MySQL.Field title;
			public MySQL.Field trade_id;
			public MySQL.Field main_word_1;
			public MySQL.Field main_word_2;
			public MySQL.Field main_word_3;
			public MySQL.Field main_word_4;
			public MySQL.Field main_word_5;
			public MySQL.Field key_word_1;
			public MySQL.Field key_word_2;
			public MySQL.Field key_word_3;
			public MySQL.Field prefix_1;
			public MySQL.Field prefix_2;
			public MySQL.Field prefix_3;
			public MySQL.Field prefix_4;
			public MySQL.Field prefix_5;
			public MySQL.Field suffix_1;
			public MySQL.Field suffix_2;
			public MySQL.Field suffix_3;
			public MySQL.Field suffix_4;
			public MySQL.Field suffix_5;
			public MySQL.Field is_show_index;
			public MySQL.Field currency;
			public MySQL.Field price;
			public MySQL.Field unit;
			public MySQL.Field url;
			public MySQL.Field description;
			public MySQL.Field description_html;
			public MySQL.Field style_id;
			public MySQL.Field site_id;
			public MySQL.Field release_id;
			public MySQL.Field create_id;
			public MySQL.Field owner_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field prefix_1_suffix;
			public MySQL.Field prefix_2_suffix;
			public MySQL.Field prefix_3_suffix;
			public MySQL.Field prefix_4_suffix;
			public MySQL.Field prefix_5_suffix;
			public MySQL.Field suffix_1_prefix;
			public MySQL.Field suffix_2_prefix;
			public MySQL.Field suffix_3_prefix;
			public MySQL.Field suffix_4_prefix;
			public MySQL.Field suffix_5_prefix;
			public MySQL.Field is_erased;
			public MySQL.Field state;
			public MySQL.Field cause;

			public t_synth_product()
			{
				TableName = "t_synth_product";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				trademark = new MySQL.Field(this, "trademark", "trademark", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				main_word_1 = new MySQL.Field(this, "main_word_1", "main_word_1", MySqlDbType.VarChar, false);
				main_word_2 = new MySQL.Field(this, "main_word_2", "main_word_2", MySqlDbType.VarChar, false);
				main_word_3 = new MySQL.Field(this, "main_word_3", "main_word_3", MySqlDbType.VarChar, false);
				main_word_4 = new MySQL.Field(this, "main_word_4", "main_word_4", MySqlDbType.VarChar, false);
				main_word_5 = new MySQL.Field(this, "main_word_5", "main_word_5", MySqlDbType.VarChar, false);
				key_word_1 = new MySQL.Field(this, "key_word_1", "key_word_1", MySqlDbType.VarChar, false);
				key_word_2 = new MySQL.Field(this, "key_word_2", "key_word_2", MySqlDbType.VarChar, false);
				key_word_3 = new MySQL.Field(this, "key_word_3", "key_word_3", MySqlDbType.VarChar, false);
				prefix_1 = new MySQL.Field(this, "prefix_1", "prefix_1", MySqlDbType.VarChar, false);
				prefix_2 = new MySQL.Field(this, "prefix_2", "prefix_2", MySqlDbType.VarChar, false);
				prefix_3 = new MySQL.Field(this, "prefix_3", "prefix_3", MySqlDbType.VarChar, false);
				prefix_4 = new MySQL.Field(this, "prefix_4", "prefix_4", MySqlDbType.VarChar, false);
				prefix_5 = new MySQL.Field(this, "prefix_5", "prefix_5", MySqlDbType.VarChar, false);
				suffix_1 = new MySQL.Field(this, "suffix_1", "suffix_1", MySqlDbType.VarChar, false);
				suffix_2 = new MySQL.Field(this, "suffix_2", "suffix_2", MySqlDbType.VarChar, false);
				suffix_3 = new MySQL.Field(this, "suffix_3", "suffix_3", MySqlDbType.VarChar, false);
				suffix_4 = new MySQL.Field(this, "suffix_4", "suffix_4", MySqlDbType.VarChar, false);
				suffix_5 = new MySQL.Field(this, "suffix_5", "suffix_5", MySqlDbType.VarChar, false);
				is_show_index = new MySQL.Field(this, "is_show_index", "is_show_index", MySqlDbType.Bit, false);
				currency = new MySQL.Field(this, "currency", "currency", MySqlDbType.VarChar, false);
				price = new MySQL.Field(this, "price", "price", MySqlDbType.VarChar, false);
				unit = new MySQL.Field(this, "unit", "unit", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.Text, false);
				description_html = new MySQL.Field(this, "description_html", "description_html", MySqlDbType.Text, false);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				create_id = new MySQL.Field(this, "create_id", "create_id", MySqlDbType.Int64, false);
				owner_id = new MySQL.Field(this, "owner_id", "owner_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				prefix_1_suffix = new MySQL.Field(this, "prefix_1_suffix", "prefix_1_suffix", MySqlDbType.VarChar, false);
				prefix_2_suffix = new MySQL.Field(this, "prefix_2_suffix", "prefix_2_suffix", MySqlDbType.VarChar, false);
				prefix_3_suffix = new MySQL.Field(this, "prefix_3_suffix", "prefix_3_suffix", MySqlDbType.VarChar, false);
				prefix_4_suffix = new MySQL.Field(this, "prefix_4_suffix", "prefix_4_suffix", MySqlDbType.VarChar, false);
				prefix_5_suffix = new MySQL.Field(this, "prefix_5_suffix", "prefix_5_suffix", MySqlDbType.VarChar, false);
				suffix_1_prefix = new MySQL.Field(this, "suffix_1_prefix", "suffix_1_prefix", MySqlDbType.VarChar, false);
				suffix_2_prefix = new MySQL.Field(this, "suffix_2_prefix", "suffix_2_prefix", MySqlDbType.VarChar, false);
				suffix_3_prefix = new MySQL.Field(this, "suffix_3_prefix", "suffix_3_prefix", MySqlDbType.VarChar, false);
				suffix_4_prefix = new MySQL.Field(this, "suffix_4_prefix", "suffix_4_prefix", MySqlDbType.VarChar, false);
				suffix_5_prefix = new MySQL.Field(this, "suffix_5_prefix", "suffix_5_prefix", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_product_area : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field area_id;
			public MySQL.Field must_level;
			public MySQL.Field type_id;

			public t_synth_product_area()
			{
				TableName = "t_synth_product_area";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				area_id = new MySQL.Field(this, "area_id", "area_id", MySqlDbType.Int64, false);
				must_level = new MySQL.Field(this, "must_level", "must_level", MySqlDbType.Int24, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_product_copy : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field trademark;
			public MySQL.Field type_id;
			public MySQL.Field title;
			public MySQL.Field trade_id;
			public MySQL.Field main_word_1;
			public MySQL.Field main_word_2;
			public MySQL.Field main_word_3;
			public MySQL.Field main_word_4;
			public MySQL.Field key_word_1;
			public MySQL.Field key_word_2;
			public MySQL.Field key_word_3;
			public MySQL.Field prefix_1;
			public MySQL.Field prefix_2;
			public MySQL.Field prefix_3;
			public MySQL.Field prefix_4;
			public MySQL.Field prefix_5;
			public MySQL.Field suffix_1;
			public MySQL.Field suffix_2;
			public MySQL.Field suffix_3;
			public MySQL.Field suffix_4;
			public MySQL.Field suffix_5;
			public MySQL.Field is_show_index;
			public MySQL.Field currency;
			public MySQL.Field price;
			public MySQL.Field unit;
			public MySQL.Field url;
			public MySQL.Field description;
			public MySQL.Field description_html;
			public MySQL.Field style_id;
			public MySQL.Field site_id;
			public MySQL.Field release_id;
			public MySQL.Field create_id;
			public MySQL.Field owner_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field prefix_1_suffix;
			public MySQL.Field prefix_2_suffix;
			public MySQL.Field prefix_3_suffix;
			public MySQL.Field prefix_4_suffix;
			public MySQL.Field prefix_5_suffix;
			public MySQL.Field suffix_1_prefix;
			public MySQL.Field suffix_2_prefix;
			public MySQL.Field suffix_3_prefix;
			public MySQL.Field suffix_4_prefix;
			public MySQL.Field suffix_5_prefix;
			public MySQL.Field is_erased;
			public MySQL.Field state;
			public MySQL.Field cause;

			public t_synth_product_copy()
			{
				TableName = "t_synth_product_copy";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				trademark = new MySQL.Field(this, "trademark", "trademark", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				main_word_1 = new MySQL.Field(this, "main_word_1", "main_word_1", MySqlDbType.VarChar, false);
				main_word_2 = new MySQL.Field(this, "main_word_2", "main_word_2", MySqlDbType.VarChar, false);
				main_word_3 = new MySQL.Field(this, "main_word_3", "main_word_3", MySqlDbType.VarChar, false);
				main_word_4 = new MySQL.Field(this, "main_word_4", "main_word_4", MySqlDbType.VarChar, false);
				key_word_1 = new MySQL.Field(this, "key_word_1", "key_word_1", MySqlDbType.VarChar, false);
				key_word_2 = new MySQL.Field(this, "key_word_2", "key_word_2", MySqlDbType.VarChar, false);
				key_word_3 = new MySQL.Field(this, "key_word_3", "key_word_3", MySqlDbType.VarChar, false);
				prefix_1 = new MySQL.Field(this, "prefix_1", "prefix_1", MySqlDbType.VarChar, false);
				prefix_2 = new MySQL.Field(this, "prefix_2", "prefix_2", MySqlDbType.VarChar, false);
				prefix_3 = new MySQL.Field(this, "prefix_3", "prefix_3", MySqlDbType.VarChar, false);
				prefix_4 = new MySQL.Field(this, "prefix_4", "prefix_4", MySqlDbType.VarChar, false);
				prefix_5 = new MySQL.Field(this, "prefix_5", "prefix_5", MySqlDbType.VarChar, false);
				suffix_1 = new MySQL.Field(this, "suffix_1", "suffix_1", MySqlDbType.VarChar, false);
				suffix_2 = new MySQL.Field(this, "suffix_2", "suffix_2", MySqlDbType.VarChar, false);
				suffix_3 = new MySQL.Field(this, "suffix_3", "suffix_3", MySqlDbType.VarChar, false);
				suffix_4 = new MySQL.Field(this, "suffix_4", "suffix_4", MySqlDbType.VarChar, false);
				suffix_5 = new MySQL.Field(this, "suffix_5", "suffix_5", MySqlDbType.VarChar, false);
				is_show_index = new MySQL.Field(this, "is_show_index", "is_show_index", MySqlDbType.Bit, false);
				currency = new MySQL.Field(this, "currency", "currency", MySqlDbType.VarChar, false);
				price = new MySQL.Field(this, "price", "price", MySqlDbType.VarChar, false);
				unit = new MySQL.Field(this, "unit", "unit", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.Text, false);
				description_html = new MySQL.Field(this, "description_html", "description_html", MySqlDbType.Text, false);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				create_id = new MySQL.Field(this, "create_id", "create_id", MySqlDbType.Int64, false);
				owner_id = new MySQL.Field(this, "owner_id", "owner_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				prefix_1_suffix = new MySQL.Field(this, "prefix_1_suffix", "prefix_1_suffix", MySqlDbType.VarChar, false);
				prefix_2_suffix = new MySQL.Field(this, "prefix_2_suffix", "prefix_2_suffix", MySqlDbType.VarChar, false);
				prefix_3_suffix = new MySQL.Field(this, "prefix_3_suffix", "prefix_3_suffix", MySqlDbType.VarChar, false);
				prefix_4_suffix = new MySQL.Field(this, "prefix_4_suffix", "prefix_4_suffix", MySqlDbType.VarChar, false);
				prefix_5_suffix = new MySQL.Field(this, "prefix_5_suffix", "prefix_5_suffix", MySqlDbType.VarChar, false);
				suffix_1_prefix = new MySQL.Field(this, "suffix_1_prefix", "suffix_1_prefix", MySqlDbType.VarChar, false);
				suffix_2_prefix = new MySQL.Field(this, "suffix_2_prefix", "suffix_2_prefix", MySqlDbType.VarChar, false);
				suffix_3_prefix = new MySQL.Field(this, "suffix_3_prefix", "suffix_3_prefix", MySqlDbType.VarChar, false);
				suffix_4_prefix = new MySQL.Field(this, "suffix_4_prefix", "suffix_4_prefix", MySqlDbType.VarChar, false);
				suffix_5_prefix = new MySQL.Field(this, "suffix_5_prefix", "suffix_5_prefix", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_product_description : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field description;
			public MySQL.Field description_html;
			public MySQL.Field is_erased;

			public t_synth_product_description()
			{
				TableName = "t_synth_product_description";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.Text, false);
				description_html = new MySQL.Field(this, "description_html", "description_html", MySqlDbType.Text, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_product_image : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field file_path;
			public MySQL.Field type;

			public t_synth_product_image()
			{
				TableName = "t_synth_product_image";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				file_path = new MySQL.Field(this, "file_path", "file_path", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_product_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field style_list_id;
			public MySQL.Field value;
			public MySQL.Field is_list;
			public MySQL.Field is_readonly;
			public MySQL.Field state;
			public MySQL.Field order;
			public MySQL.Field is_key_word;
			public MySQL.Field position_id;

			public t_synth_product_list()
			{
				TableName = "t_synth_product_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				style_list_id = new MySQL.Field(this, "style_list_id", "style_list_id", MySqlDbType.Int64, false);
				value = new MySQL.Field(this, "value", "value", MySqlDbType.VarChar, false);
				is_list = new MySQL.Field(this, "is_list", "is_list", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				order = new MySQL.Field(this, "order", "order", MySqlDbType.Int64, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				position_id = new MySQL.Field(this, "position_id", "position_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_product_list_data : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field list_id;
			public MySQL.Field type;
			public MySQL.Field is_table;
			public MySQL.Field is_readonly;
			public MySQL.Field is_key_word;
			public MySQL.Field key_type;

			public t_synth_product_list_data()
			{
				TableName = "t_synth_product_list_data";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				list_id = new MySQL.Field(this, "list_id", "list_id", MySqlDbType.Int64, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int64, false);
				is_table = new MySQL.Field(this, "is_table", "is_table", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				key_type = new MySQL.Field(this, "key_type", "key_type", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_product_para : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field type_id;
			public MySQL.Field para_type_id;

			public t_synth_product_para()
			{
				TableName = "t_synth_product_para";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				para_type_id = new MySQL.Field(this, "para_type_id", "para_type_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_product_style : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field user_id;
			public MySQL.Field parent_id;
			public MySQL.Field order;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field state;
			public MySQL.Field is_system;
			public MySQL.Field parent_path;

			public t_synth_product_style()
			{
				TableName = "t_synth_product_style";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				order = new MySQL.Field(this, "order", "order", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_system = new MySQL.Field(this, "is_system", "is_system", MySqlDbType.Bit, false);
				parent_path = new MySQL.Field(this, "parent_path", "parent_path", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_product_style_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field style_id;
			public MySQL.Field style_list_id;
			public MySQL.Field display;
			public MySQL.Field value;
			public MySQL.Field is_list;
			public MySQL.Field is_readonly;
			public MySQL.Field state;
			public MySQL.Field must_level;
			public MySQL.Field min_lenght;
			public MySQL.Field max_lenght;
			public MySQL.Field word_position_id;
			public MySQL.Field word_type_id;
			public MySQL.Field is_key_word;
			public MySQL.Field is_muliti_line;
			public MySQL.Field is_erased;
			public MySQL.Field order_id;

			public t_synth_product_style_list()
			{
				TableName = "t_synth_product_style_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				style_list_id = new MySQL.Field(this, "style_list_id", "style_list_id", MySqlDbType.Int64, false);
				display = new MySQL.Field(this, "display", "display", MySqlDbType.VarChar, false);
				value = new MySQL.Field(this, "value", "value", MySqlDbType.VarChar, false);
				is_list = new MySQL.Field(this, "is_list", "is_list", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				must_level = new MySQL.Field(this, "must_level", "must_level", MySqlDbType.Int24, false);
				min_lenght = new MySQL.Field(this, "min_lenght", "min_lenght", MySqlDbType.Int64, false);
				max_lenght = new MySQL.Field(this, "max_lenght", "max_lenght", MySqlDbType.Int64, false);
				word_position_id = new MySQL.Field(this, "word_position_id", "word_position_id", MySqlDbType.Int64, false);
				word_type_id = new MySQL.Field(this, "word_type_id", "word_type_id", MySqlDbType.Int64, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Int64, false);
				is_muliti_line = new MySQL.Field(this, "is_muliti_line", "is_muliti_line", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_product_style_list_data : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field list_id;
			public MySQL.Field para_id;
			public MySQL.Field table_name;
			public MySQL.Field is_table;
			public MySQL.Field is_readonly;
			public MySQL.Field is_key_word;
			public MySQL.Field key_type;

			public t_synth_product_style_list_data()
			{
				TableName = "t_synth_product_style_list_data";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				list_id = new MySQL.Field(this, "list_id", "list_id", MySqlDbType.Int64, false);
				para_id = new MySQL.Field(this, "para_id", "para_id", MySqlDbType.Int64, false);
				table_name = new MySQL.Field(this, "table_name", "table_name", MySqlDbType.VarChar, false);
				is_table = new MySQL.Field(this, "is_table", "is_table", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				key_type = new MySQL.Field(this, "key_type", "key_type", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_product_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field parent_id;
			public MySQL.Field name;
			public MySQL.Field create_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field state;
			public MySQL.Field is_erased;
			public MySQL.Field order_id;

			public t_synth_product_type()
			{
				TableName = "t_synth_product_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				create_id = new MySQL.Field(this, "create_id", "create_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int32, false);
			}
		}

		public class t_synth_question : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field title;
			public MySQL.Field content;
			public MySQL.Field type;
			public MySQL.Field number;
			public MySQL.Field create_time;
			public MySQL.Field state;

			public t_synth_question()
			{
				TableName = "t_synth_question";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int32, false);
				number = new MySQL.Field(this, "number", "number", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_question_reply : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field question_id;
			public MySQL.Field content;
			public MySQL.Field create_time;

			public t_synth_question_reply()
			{
				TableName = "t_synth_question_reply";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				question_id = new MySQL.Field(this, "question_id", "question_id", MySqlDbType.Int64, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_synth_question_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field type_name;
			public MySQL.Field create_time;

			public t_synth_question_type()
			{
				TableName = "t_synth_question_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				type_name = new MySQL.Field(this, "type_name", "type_name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_synth_release_site : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field trade_id;
			public MySQL.Field release_name;
			public MySQL.Field user_site_url;
			public MySQL.Field user_site_name;
			public MySQL.Field create_time;
			public MySQL.Field pass_time;
			public MySQL.Field stop_time;
			public MySQL.Field update_time;
			public MySQL.Field is_temporary;
			public MySQL.Field state;
			public MySQL.Field long_quantity;
			public MySQL.Field user_id;
			public MySQL.Field is_acquiesce;
			public MySQL.Field cause;
			public MySQL.Field is_eims_url;
			public MySQL.Field eims_site_id;
			public MySQL.Field is_erased;
			public MySQL.Field restart_time;

			public t_synth_release_site()
			{
				TableName = "t_synth_release_site";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				release_name = new MySQL.Field(this, "release_name", "release_name", MySqlDbType.VarChar, false);
				user_site_url = new MySQL.Field(this, "user_site_url", "user_site_url", MySqlDbType.VarChar, false);
				user_site_name = new MySQL.Field(this, "user_site_name", "user_site_name", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pass_time = new MySQL.Field(this, "pass_time", "pass_time", MySqlDbType.DateTime, false);
				stop_time = new MySQL.Field(this, "stop_time", "stop_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_temporary = new MySQL.Field(this, "is_temporary", "is_temporary", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				long_quantity = new MySQL.Field(this, "long_quantity", "long_quantity", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				is_acquiesce = new MySQL.Field(this, "is_acquiesce", "is_acquiesce", MySqlDbType.Bit, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
				is_eims_url = new MySQL.Field(this, "is_eims_url", "is_eims_url", MySqlDbType.Bit, false);
				eims_site_id = new MySQL.Field(this, "eims_site_id", "eims_site_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				restart_time = new MySQL.Field(this, "restart_time", "restart_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_synth_release_sitemap : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field release_site_id;
			public MySQL.Field title;
			public MySQL.Field url;

			public t_synth_release_sitemap()
			{
				TableName = "t_synth_release_sitemap";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_site : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_id;
			public MySQL.Field owner_id;
			public MySQL.Field company_name;
			public MySQL.Field company_short_name;
			public MySQL.Field managing_mode;
			public MySQL.Field description;
			public MySQL.Field description_html;
			public MySQL.Field trade;
			public MySQL.Field product_promotion_1;
			public MySQL.Field product_promotion_2;
			public MySQL.Field product_promotion_3;
			public MySQL.Field product_promotion_4;
			public MySQL.Field product_promotion_5;
			public MySQL.Field brand_promotion_1;
			public MySQL.Field brand_promotion_2;
			public MySQL.Field brand_promotion_3;
			public MySQL.Field brand_promotion_4;
			public MySQL.Field brand_promotion_5;
			public MySQL.Field image_Logo;
			public MySQL.Field image_path;
			public MySQL.Field corporation;
			public MySQL.Field company_address;
			public MySQL.Field company_type;
			public MySQL.Field company_assets_currency;
			public MySQL.Field company_assets_id;
			public MySQL.Field company_create_time;
			public MySQL.Field domain;
			public MySQL.Field depardment;
			public MySQL.Field employees_count;
			public MySQL.Field brand_name;
			public MySQL.Field principal_place_business;
			public MySQL.Field main_market;
			public MySQL.Field main_customer_groups;
			public MySQL.Field oem;
			public MySQL.Field iso;
			public MySQL.Field quality_control;
			public MySQL.Field factory_area;
			public MySQL.Field monthly_output;
			public MySQL.Field monthly_output_unit;
			public MySQL.Field annual_sales_volume_id;
			public MySQL.Field annual_export;
			public MySQL.Field annual_import;
			public MySQL.Field bank;
			public MySQL.Field bank_account;
			public MySQL.Field contact;
			public MySQL.Field sex;
			public MySQL.Field diploma;
			public MySQL.Field email;
			public MySQL.Field mobile_area;
			public MySQL.Field time_limit;
			public MySQL.Field business_licence;
			public MySQL.Field tax_registration;
			public MySQL.Field scope_business;
			public MySQL.Field scope_business_html;
			public MySQL.Field annual_survey_time;
			public MySQL.Field registration_authority;
			public MySQL.Field area_id;
			public MySQL.Field area_detailed;
			public MySQL.Field post;
			public MySQL.Field post_code;
			public MySQL.Field phone_400;
			public MySQL.Field qq;
			public MySQL.Field phone2;
			public MySQL.Field phone3;
			public MySQL.Field phone4;
			public MySQL.Field mobile;
			public MySQL.Field phone1;
			public MySQL.Field ww;
			public MySQL.Field create_time;
			public MySQL.Field fax1;
			public MySQL.Field fax2;
			public MySQL.Field fax3;
			public MySQL.Field fax4;
			public MySQL.Field other_phone;
			public MySQL.Field integrity;
			public MySQL.Field integrity_number;
			public MySQL.Field update_time;
			public MySQL.Field state;
			public MySQL.Field is_erased;
			public MySQL.Field cause;
			public MySQL.Field publish_rsite_grade_id;

			public t_synth_site()
			{
				TableName = "t_synth_site";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_id = new MySQL.Field(this, "create_id", "create_id", MySqlDbType.Int64, false);
				owner_id = new MySQL.Field(this, "owner_id", "owner_id", MySqlDbType.Int64, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				company_short_name = new MySQL.Field(this, "company_short_name", "company_short_name", MySqlDbType.VarChar, false);
				managing_mode = new MySQL.Field(this, "managing_mode", "managing_mode", MySqlDbType.Int64, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.VarChar, false);
				description_html = new MySQL.Field(this, "description_html", "description_html", MySqlDbType.Text, false);
				trade = new MySQL.Field(this, "trade", "trade", MySqlDbType.VarChar, false);
				product_promotion_1 = new MySQL.Field(this, "product_promotion_1", "product_promotion_1", MySqlDbType.VarChar, false);
				product_promotion_2 = new MySQL.Field(this, "product_promotion_2", "product_promotion_2", MySqlDbType.VarChar, false);
				product_promotion_3 = new MySQL.Field(this, "product_promotion_3", "product_promotion_3", MySqlDbType.VarChar, false);
				product_promotion_4 = new MySQL.Field(this, "product_promotion_4", "product_promotion_4", MySqlDbType.VarChar, false);
				product_promotion_5 = new MySQL.Field(this, "product_promotion_5", "product_promotion_5", MySqlDbType.VarChar, false);
				brand_promotion_1 = new MySQL.Field(this, "brand_promotion_1", "brand_promotion_1", MySqlDbType.VarChar, false);
				brand_promotion_2 = new MySQL.Field(this, "brand_promotion_2", "brand_promotion_2", MySqlDbType.VarChar, false);
				brand_promotion_3 = new MySQL.Field(this, "brand_promotion_3", "brand_promotion_3", MySqlDbType.VarChar, false);
				brand_promotion_4 = new MySQL.Field(this, "brand_promotion_4", "brand_promotion_4", MySqlDbType.VarChar, false);
				brand_promotion_5 = new MySQL.Field(this, "brand_promotion_5", "brand_promotion_5", MySqlDbType.VarChar, false);
				image_Logo = new MySQL.Field(this, "image_Logo", "image_Logo", MySqlDbType.VarChar, false);
				image_path = new MySQL.Field(this, "image_path", "image_path", MySqlDbType.VarChar, false);
				corporation = new MySQL.Field(this, "corporation", "corporation", MySqlDbType.VarChar, false);
				company_address = new MySQL.Field(this, "company_address", "company_address", MySqlDbType.VarChar, false);
				company_type = new MySQL.Field(this, "company_type", "company_type", MySqlDbType.Int64, false);
				company_assets_currency = new MySQL.Field(this, "company_assets_currency", "company_assets_currency", MySqlDbType.VarChar, false);
				company_assets_id = new MySQL.Field(this, "company_assets_id", "company_assets_id", MySqlDbType.VarChar, false);
				company_create_time = new MySQL.Field(this, "company_create_time", "company_create_time", MySqlDbType.VarChar, false);
				domain = new MySQL.Field(this, "domain", "domain", MySqlDbType.VarChar, false);
				depardment = new MySQL.Field(this, "depardment", "depardment", MySqlDbType.VarChar, false);
				employees_count = new MySQL.Field(this, "employees_count", "employees_count", MySqlDbType.Int64, false);
				brand_name = new MySQL.Field(this, "brand_name", "brand_name", MySqlDbType.VarChar, false);
				principal_place_business = new MySQL.Field(this, "principal_place_business", "principal_place_business", MySqlDbType.VarChar, false);
				main_market = new MySQL.Field(this, "main_market", "main_market", MySqlDbType.VarChar, false);
				main_customer_groups = new MySQL.Field(this, "main_customer_groups", "main_customer_groups", MySqlDbType.VarChar, false);
				oem = new MySQL.Field(this, "oem", "oem", MySqlDbType.Bit, false);
				iso = new MySQL.Field(this, "iso", "iso", MySqlDbType.VarChar, false);
				quality_control = new MySQL.Field(this, "quality_control", "quality_control", MySqlDbType.Int64, false);
				factory_area = new MySQL.Field(this, "factory_area", "factory_area", MySqlDbType.VarChar, false);
				monthly_output = new MySQL.Field(this, "monthly_output", "monthly_output", MySqlDbType.VarChar, false);
				monthly_output_unit = new MySQL.Field(this, "monthly_output_unit", "monthly_output_unit", MySqlDbType.VarChar, false);
				annual_sales_volume_id = new MySQL.Field(this, "annual_sales_volume_id", "annual_sales_volume_id", MySqlDbType.Int64, false);
				annual_export = new MySQL.Field(this, "annual_export", "annual_export", MySqlDbType.Int64, false);
				annual_import = new MySQL.Field(this, "annual_import", "annual_import", MySqlDbType.Int64, false);
				bank = new MySQL.Field(this, "bank", "bank", MySqlDbType.VarChar, false);
				bank_account = new MySQL.Field(this, "bank_account", "bank_account", MySqlDbType.VarChar, false);
				contact = new MySQL.Field(this, "contact", "contact", MySqlDbType.VarChar, false);
				sex = new MySQL.Field(this, "sex", "sex", MySqlDbType.Bit, false);
				diploma = new MySQL.Field(this, "diploma", "diploma", MySqlDbType.VarChar, false);
				email = new MySQL.Field(this, "email", "email", MySqlDbType.VarChar, false);
				mobile_area = new MySQL.Field(this, "mobile_area", "mobile_area", MySqlDbType.VarChar, false);
				time_limit = new MySQL.Field(this, "time_limit", "time_limit", MySqlDbType.VarChar, false);
				business_licence = new MySQL.Field(this, "business_licence", "business_licence", MySqlDbType.VarChar, false);
				tax_registration = new MySQL.Field(this, "tax_registration", "tax_registration", MySqlDbType.VarChar, false);
				scope_business = new MySQL.Field(this, "scope_business", "scope_business", MySqlDbType.VarChar, false);
				scope_business_html = new MySQL.Field(this, "scope_business_html", "scope_business_html", MySqlDbType.Text, false);
				annual_survey_time = new MySQL.Field(this, "annual_survey_time", "annual_survey_time", MySqlDbType.VarChar, false);
				registration_authority = new MySQL.Field(this, "registration_authority", "registration_authority", MySqlDbType.VarChar, false);
				area_id = new MySQL.Field(this, "area_id", "area_id", MySqlDbType.Int64, false);
				area_detailed = new MySQL.Field(this, "area_detailed", "area_detailed", MySqlDbType.VarChar, false);
				post = new MySQL.Field(this, "post", "post", MySqlDbType.VarChar, false);
				post_code = new MySQL.Field(this, "post_code", "post_code", MySqlDbType.VarChar, false);
				phone_400 = new MySQL.Field(this, "phone_400", "phone_400", MySqlDbType.VarChar, false);
				qq = new MySQL.Field(this, "qq", "qq", MySqlDbType.VarChar, false);
				phone2 = new MySQL.Field(this, "phone2", "phone2", MySqlDbType.VarChar, false);
				phone3 = new MySQL.Field(this, "phone3", "phone3", MySqlDbType.VarChar, false);
				phone4 = new MySQL.Field(this, "phone4", "phone4", MySqlDbType.VarChar, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				phone1 = new MySQL.Field(this, "phone1", "phone1", MySqlDbType.VarChar, false);
				ww = new MySQL.Field(this, "ww", "ww", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				fax1 = new MySQL.Field(this, "fax1", "fax1", MySqlDbType.VarChar, false);
				fax2 = new MySQL.Field(this, "fax2", "fax2", MySqlDbType.VarChar, false);
				fax3 = new MySQL.Field(this, "fax3", "fax3", MySqlDbType.VarChar, false);
				fax4 = new MySQL.Field(this, "fax4", "fax4", MySqlDbType.VarChar, false);
				other_phone = new MySQL.Field(this, "other_phone", "other_phone", MySqlDbType.VarChar, false);
				integrity = new MySQL.Field(this, "integrity", "integrity", MySqlDbType.VarChar, false);
				integrity_number = new MySQL.Field(this, "integrity_number", "integrity_number", MySqlDbType.VarChar, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				cause = new MySQL.Field(this, "cause", "cause", MySqlDbType.VarChar, false);
				publish_rsite_grade_id = new MySQL.Field(this, "publish_rsite_grade_id", "publish_rsite_grade_id", MySqlDbType.Int32, false);
			}
		}

		public class t_synth_site_honour : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field site_para_id;
			public MySQL.Field datum_name;
			public MySQL.Field department_name;
			public MySQL.Field file_path;
			public MySQL.Field must_level;
			public MySQL.Field create_time;
			public MySQL.Field auditing_time;
			public MySQL.Field update_time;
			public MySQL.Field state;
			public MySQL.Field is_erased;
			public MySQL.Field sort;

			public t_synth_site_honour()
			{
				TableName = "t_synth_site_honour";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				site_para_id = new MySQL.Field(this, "site_para_id", "site_para_id", MySqlDbType.Int64, false);
				datum_name = new MySQL.Field(this, "datum_name", "datum_name", MySqlDbType.VarChar, false);
				department_name = new MySQL.Field(this, "department_name", "department_name", MySqlDbType.VarChar, false);
				file_path = new MySQL.Field(this, "file_path", "file_path", MySqlDbType.VarChar, false);
				must_level = new MySQL.Field(this, "must_level", "must_level", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				auditing_time = new MySQL.Field(this, "auditing_time", "auditing_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Int24, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int32, false);
			}
		}

		public class t_synth_site_para : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field type_id;
			public MySQL.Field is_erased;
			public MySQL.Field owner_id;

			public t_synth_site_para()
			{
				TableName = "t_synth_site_para";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				owner_id = new MySQL.Field(this, "owner_id", "owner_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_site_para_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field is_key_word;

			public t_synth_site_para_type()
			{
				TableName = "t_synth_site_para_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_site_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field trade1_id;
			public MySQL.Field trade2_id;
			public MySQL.Field trade3_id;

			public t_synth_site_trade()
			{
				TableName = "t_synth_site_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				trade1_id = new MySQL.Field(this, "trade1_id", "trade1_id", MySqlDbType.Int64, false);
				trade2_id = new MySQL.Field(this, "trade2_id", "trade2_id", MySqlDbType.Int64, false);
				trade3_id = new MySQL.Field(this, "trade3_id", "trade3_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_style_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field display;
			public MySQL.Field value;
			public MySQL.Field is_list;
			public MySQL.Field is_readonly;
			public MySQL.Field state;
			public MySQL.Field must_level;
			public MySQL.Field min_lenght;
			public MySQL.Field max_lenght;
			public MySQL.Field word_position_id;
			public MySQL.Field word_type_id;
			public MySQL.Field is_key_word;
			public MySQL.Field is_muliti_line;
			public MySQL.Field is_erased;
			public MySQL.Field order_id;

			public t_synth_style_list()
			{
				TableName = "t_synth_style_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				display = new MySQL.Field(this, "display", "display", MySqlDbType.VarChar, false);
				value = new MySQL.Field(this, "value", "value", MySqlDbType.VarChar, false);
				is_list = new MySQL.Field(this, "is_list", "is_list", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				must_level = new MySQL.Field(this, "must_level", "must_level", MySqlDbType.Int24, false);
				min_lenght = new MySQL.Field(this, "min_lenght", "min_lenght", MySqlDbType.Int64, false);
				max_lenght = new MySQL.Field(this, "max_lenght", "max_lenght", MySqlDbType.Int64, false);
				word_position_id = new MySQL.Field(this, "word_position_id", "word_position_id", MySqlDbType.Int64, false);
				word_type_id = new MySQL.Field(this, "word_type_id", "word_type_id", MySqlDbType.Int64, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Int64, false);
				is_muliti_line = new MySQL.Field(this, "is_muliti_line", "is_muliti_line", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				order_id = new MySQL.Field(this, "order_id", "order_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_style_list_data : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field list_id;
			public MySQL.Field para_id;
			public MySQL.Field table_name;
			public MySQL.Field is_table;
			public MySQL.Field is_readonly;
			public MySQL.Field is_key_word;
			public MySQL.Field key_type;

			public t_synth_style_list_data()
			{
				TableName = "t_synth_style_list_data";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				list_id = new MySQL.Field(this, "list_id", "list_id", MySqlDbType.Int64, false);
				para_id = new MySQL.Field(this, "para_id", "para_id", MySqlDbType.Int64, false);
				table_name = new MySQL.Field(this, "table_name", "table_name", MySqlDbType.VarChar, false);
				is_table = new MySQL.Field(this, "is_table", "is_table", MySqlDbType.Bit, false);
				is_readonly = new MySQL.Field(this, "is_readonly", "is_readonly", MySqlDbType.Bit, false);
				is_key_word = new MySQL.Field(this, "is_key_word", "is_key_word", MySqlDbType.Bit, false);
				key_type = new MySQL.Field(this, "key_type", "key_type", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_system_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field record_time;
			public MySQL.Field user_id;
			public MySQL.Field ip;
			public MySQL.Field message;
			public MySQL.Field url;
			public MySQL.Field type;

			public t_synth_system_log()
			{
				TableName = "t_synth_system_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				record_time = new MySQL.Field(this, "record_time", "record_time", MySqlDbType.DateTime, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int32, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				message = new MySQL.Field(this, "message", "message", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_title : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field model_id;
			public MySQL.Field word_list_id;
			public MySQL.Field title;
			public MySQL.Field t_release_id;
			public MySQL.Field t_word_id;
			public MySQL.Field t_title_id;
			public MySQL.Field user_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field is_included;
			public MySQL.Field last_time;
			public MySQL.Field include_url;

			public t_synth_title()
			{
				TableName = "t_synth_title";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				model_id = new MySQL.Field(this, "model_id", "model_id", MySqlDbType.Int64, false);
				word_list_id = new MySQL.Field(this, "word_list_id", "word_list_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				t_release_id = new MySQL.Field(this, "t_release_id", "t_release_id", MySqlDbType.Int64, false);
				t_word_id = new MySQL.Field(this, "t_word_id", "t_word_id", MySqlDbType.Int64, false);
				t_title_id = new MySQL.Field(this, "t_title_id", "t_title_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_included = new MySQL.Field(this, "is_included", "is_included", MySqlDbType.Int24, false);
				last_time = new MySQL.Field(this, "last_time", "last_time", MySqlDbType.DateTime, false);
				include_url = new MySQL.Field(this, "include_url", "include_url", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_title_list : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field title;
			public MySQL.Field t_release_id;
			public MySQL.Field content;
			public MySQL.Field content_head_id;
			public MySQL.Field content_head;
			public MySQL.Field centre_content_id;
			public MySQL.Field centre_content;
			public MySQL.Field tail_content_id;
			public MySQL.Field site_id;
			public MySQL.Field tail_content;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_synth_title_list()
			{
				TableName = "t_synth_title_list";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				t_release_id = new MySQL.Field(this, "t_release_id", "t_release_id", MySqlDbType.Int64, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_head_id = new MySQL.Field(this, "content_head_id", "content_head_id", MySqlDbType.Int64, false);
				content_head = new MySQL.Field(this, "content_head", "content_head", MySqlDbType.Text, false);
				centre_content_id = new MySQL.Field(this, "centre_content_id", "centre_content_id", MySqlDbType.Int64, false);
				centre_content = new MySQL.Field(this, "centre_content", "centre_content", MySqlDbType.Text, false);
				tail_content_id = new MySQL.Field(this, "tail_content_id", "tail_content_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				tail_content = new MySQL.Field(this, "tail_content", "tail_content", MySqlDbType.Text, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_title_list_assist : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field product_id;
			public MySQL.Field site_id;
			public MySQL.Field create_time;

			public t_synth_title_list_assist()
			{
				TableName = "t_synth_title_list_assist";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_synth_title_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field product_id;
			public MySQL.Field t_release_id;
			public MySQL.Field t_synth_title_list_id;
			public MySQL.Field title_id;
			public MySQL.Field title;
			public MySQL.Field title_type;
			public MySQL.Field title_md5;
			public MySQL.Field content;
			public MySQL.Field content_md5;
			public MySQL.Field content_head_id;
			public MySQL.Field content_head;
			public MySQL.Field content_middle_id;
			public MySQL.Field content_middle;
			public MySQL.Field content_end_id;
			public MySQL.Field content_end;

			public t_synth_title_log()
			{
				TableName = "t_synth_title_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				t_release_id = new MySQL.Field(this, "t_release_id", "t_release_id", MySqlDbType.Int64, false);
				t_synth_title_list_id = new MySQL.Field(this, "t_synth_title_list_id", "t_synth_title_list_id", MySqlDbType.Int64, false);
				title_id = new MySQL.Field(this, "title_id", "title_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				title_type = new MySQL.Field(this, "title_type", "title_type", MySqlDbType.Int32, false);
				title_md5 = new MySQL.Field(this, "title_md5", "title_md5", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_md5 = new MySQL.Field(this, "content_md5", "content_md5", MySqlDbType.VarChar, false);
				content_head_id = new MySQL.Field(this, "content_head_id", "content_head_id", MySqlDbType.Int64, false);
				content_head = new MySQL.Field(this, "content_head", "content_head", MySqlDbType.Text, false);
				content_middle_id = new MySQL.Field(this, "content_middle_id", "content_middle_id", MySqlDbType.Int64, false);
				content_middle = new MySQL.Field(this, "content_middle", "content_middle", MySqlDbType.Text, false);
				content_end_id = new MySQL.Field(this, "content_end_id", "content_end_id", MySqlDbType.Int64, false);
				content_end = new MySQL.Field(this, "content_end", "content_end", MySqlDbType.Text, false);
			}
		}

		public class t_synth_title_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field title_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_synth_title_release()
			{
				TableName = "t_synth_title_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				title_id = new MySQL.Field(this, "title_id", "title_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_synth_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field parent_id;
			public MySQL.Field trade_id;
			public MySQL.Field order;
			public MySQL.Field is_erased;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field parent_path;
			public MySQL.Field is_system;
			public MySQL.Field user_id;
			public MySQL.Field coefficient;

			public t_synth_trade()
			{
				TableName = "t_synth_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
				order = new MySQL.Field(this, "order", "order", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				parent_path = new MySQL.Field(this, "parent_path", "parent_path", MySqlDbType.VarChar, false);
				is_system = new MySQL.Field(this, "is_system", "is_system", MySqlDbType.Bit, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int32, false);
				coefficient = new MySQL.Field(this, "coefficient", "coefficient", MySqlDbType.Decimal, false);
			}
		}

		public class t_synth_trade_synonymy : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field type;
			public MySQL.Field trade_id;
			public MySQL.Field dest_trade_id;
			public MySQL.Field trade_name;

			public t_synth_trade_synonymy()
			{
				TableName = "t_synth_trade_synonymy";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.VarChar, false);
				dest_trade_id = new MySQL.Field(this, "dest_trade_id", "dest_trade_id", MySqlDbType.VarChar, false);
				trade_name = new MySQL.Field(this, "trade_name", "trade_name", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_user : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field application_id;
			public MySQL.Field instance_id;
			public MySQL.Field created_id;
			public MySQL.Field owner_id;
			public MySQL.Field eims_id;
			public MySQL.Field user_name;
			public MySQL.Field password;
			public MySQL.Field password_md5;
			public MySQL.Field sex;
			public MySQL.Field email;
			public MySQL.Field company_name;
			public MySQL.Field company_abbreviation;
			public MySQL.Field phone;
			public MySQL.Field fax;
			public MySQL.Field mobile;
			public MySQL.Field address;
			public MySQL.Field post_code;
			public MySQL.Field ver;
			public MySQL.Field realityName;
			public MySQL.Field defaultIdentity;
			public MySQL.Field black_figure;
			public MySQL.Field is_not_enough_m;
			public MySQL.Field last_remind_time;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field authority;
			public MySQL.Field state;

			public t_synth_user()
			{
				TableName = "t_synth_user";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				application_id = new MySQL.Field(this, "application_id", "application_id", MySqlDbType.Int64, false);
				instance_id = new MySQL.Field(this, "instance_id", "instance_id", MySqlDbType.Int64, false);
				created_id = new MySQL.Field(this, "created_id", "created_id", MySqlDbType.Int64, false);
				owner_id = new MySQL.Field(this, "owner_id", "owner_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				user_name = new MySQL.Field(this, "user_name", "user_name", MySqlDbType.VarChar, false);
				password = new MySQL.Field(this, "password", "password", MySqlDbType.VarChar, false);
				password_md5 = new MySQL.Field(this, "password_md5", "password_md5", MySqlDbType.VarChar, false);
				sex = new MySQL.Field(this, "sex", "sex", MySqlDbType.Int32, false);
				email = new MySQL.Field(this, "email", "email", MySqlDbType.VarChar, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				company_abbreviation = new MySQL.Field(this, "company_abbreviation", "company_abbreviation", MySqlDbType.VarChar, false);
				phone = new MySQL.Field(this, "phone", "phone", MySqlDbType.VarChar, false);
				fax = new MySQL.Field(this, "fax", "fax", MySqlDbType.VarChar, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				address = new MySQL.Field(this, "address", "address", MySqlDbType.VarChar, false);
				post_code = new MySQL.Field(this, "post_code", "post_code", MySqlDbType.VarChar, false);
				ver = new MySQL.Field(this, "ver", "ver", MySqlDbType.VarChar, false);
				realityName = new MySQL.Field(this, "realityName", "realityName", MySqlDbType.VarChar, false);
				defaultIdentity = new MySQL.Field(this, "defaultIdentity", "defaultIdentity", MySqlDbType.VarChar, false);
				black_figure = new MySQL.Field(this, "black_figure", "black_figure", MySqlDbType.Decimal, false);
				is_not_enough_m = new MySQL.Field(this, "is_not_enough_m", "is_not_enough_m", MySqlDbType.Bit, false);
				last_remind_time = new MySQL.Field(this, "last_remind_time", "last_remind_time", MySqlDbType.DateTime, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				authority = new MySQL.Field(this, "authority", "authority", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_word : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field prefix;
			public MySQL.Field name;
			public MySQL.Field suffix;
			public MySQL.Field display;
			public MySQL.Field type_id;
			public MySQL.Field style_id;
			public MySQL.Field is_erased;
			public MySQL.Field is_system;
			public MySQL.Field like_id;
			public MySQL.Field weight;
			public MySQL.Field span_prefix;
			public MySQL.Field span_suffix;
			public MySQL.Field is_model;
			public MySQL.Field is_model_name;
			public MySQL.Field is_model_prefix;
			public MySQL.Field is_model_suffix;
			public MySQL.Field is_model_span_prefix;
			public MySQL.Field is_model_span_suffix;
			public MySQL.Field is_dynamic;
			public MySQL.Field is_dynamic_name;
			public MySQL.Field is_dynamic_prefix;
			public MySQL.Field is_dynamic_suffix;
			public MySQL.Field is_dynamic_span_prefix;
			public MySQL.Field is_dynamic_span_suffix;
			public MySQL.Field trade_name;

			public t_synth_word()
			{
				TableName = "t_synth_word";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				prefix = new MySQL.Field(this, "prefix", "prefix", MySqlDbType.VarChar, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				suffix = new MySQL.Field(this, "suffix", "suffix", MySqlDbType.VarChar, false);
				display = new MySQL.Field(this, "display", "display", MySqlDbType.VarChar, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int64, false);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_system = new MySQL.Field(this, "is_system", "is_system", MySqlDbType.Bit, false);
				like_id = new MySQL.Field(this, "like_id", "like_id", MySqlDbType.Int64, false);
				weight = new MySQL.Field(this, "weight", "weight", MySqlDbType.Int64, false);
				span_prefix = new MySQL.Field(this, "span_prefix", "span_prefix", MySqlDbType.VarChar, false);
				span_suffix = new MySQL.Field(this, "span_suffix", "span_suffix", MySqlDbType.VarChar, false);
				is_model = new MySQL.Field(this, "is_model", "is_model", MySqlDbType.Bit, false);
				is_model_name = new MySQL.Field(this, "is_model_name", "is_model_name", MySqlDbType.Bit, false);
				is_model_prefix = new MySQL.Field(this, "is_model_prefix", "is_model_prefix", MySqlDbType.Bit, false);
				is_model_suffix = new MySQL.Field(this, "is_model_suffix", "is_model_suffix", MySqlDbType.Bit, false);
				is_model_span_prefix = new MySQL.Field(this, "is_model_span_prefix", "is_model_span_prefix", MySqlDbType.Bit, false);
				is_model_span_suffix = new MySQL.Field(this, "is_model_span_suffix", "is_model_span_suffix", MySqlDbType.Bit, false);
				is_dynamic = new MySQL.Field(this, "is_dynamic", "is_dynamic", MySqlDbType.Bit, false);
				is_dynamic_name = new MySQL.Field(this, "is_dynamic_name", "is_dynamic_name", MySqlDbType.Bit, false);
				is_dynamic_prefix = new MySQL.Field(this, "is_dynamic_prefix", "is_dynamic_prefix", MySqlDbType.Bit, false);
				is_dynamic_suffix = new MySQL.Field(this, "is_dynamic_suffix", "is_dynamic_suffix", MySqlDbType.Bit, false);
				is_dynamic_span_prefix = new MySQL.Field(this, "is_dynamic_span_prefix", "is_dynamic_span_prefix", MySqlDbType.Bit, false);
				is_dynamic_span_suffix = new MySQL.Field(this, "is_dynamic_span_suffix", "is_dynamic_span_suffix", MySqlDbType.Bit, false);
				trade_name = new MySQL.Field(this, "trade_name", "trade_name", MySqlDbType.VarChar, false);
			}
		}

		public class t_synth_word_html : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field word_id;
			public MySQL.Field html;
			public MySQL.Field html_ul;
			public MySQL.Field type_id;

			public t_synth_word_html()
			{
				TableName = "t_synth_word_html";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				html = new MySQL.Field(this, "html", "html", MySqlDbType.Text, false);
				html_ul = new MySQL.Field(this, "html_ul", "html_ul", MySqlDbType.Text, false);
				type_id = new MySQL.Field(this, "type_id", "type_id", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_word_list_error : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field word_id;
			public MySQL.Field style_id;
			public MySQL.Field product_id;
			public MySQL.Field error_type;

			public t_synth_word_list_error()
			{
				TableName = "t_synth_word_list_error";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				style_id = new MySQL.Field(this, "style_id", "style_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				error_type = new MySQL.Field(this, "error_type", "error_type", MySqlDbType.Int24, false);
			}
		}

		public class t_synth_word_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field word_id;
			public MySQL.Field trade_id;

			public t_synth_word_trade()
			{
				TableName = "t_synth_word_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				word_id = new MySQL.Field(this, "word_id", "word_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
			}
		}

		public class t_synth_word_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field name;
			public MySQL.Field description;
			public MySQL.Field order;

			public t_synth_word_type()
			{
				TableName = "t_synth_word_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.VarChar, false);
				order = new MySQL.Field(this, "order", "order", MySqlDbType.Int32, false);
			}
		}

		public class t_title_search_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_word_id;
			public MySQL.Field key_word_name;
			public MySQL.Field release_site_id;
			public MySQL.Field ranking;
			public MySQL.Field position;
			public MySQL.Field url;
			public MySQL.Field search_type;
			public MySQL.Field is_release_site_data;
			public MySQL.Field is_platform;
			public MySQL.Field count;
			public MySQL.Field overall_count;
			public MySQL.Field html_url;
			public MySQL.Field label_type;
			public MySQL.Field label_attribute_type;
			public MySQL.Field label_attribute_value;
			public MySQL.Field label_position;
			public MySQL.Field datetime;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field is_short;
			public MySQL.Field is_erased;

			public t_title_search_count()
			{
				TableName = "t_title_search_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				is_release_site_data = new MySQL.Field(this, "is_release_site_data", "is_release_site_data", MySqlDbType.Bit, false);
				is_platform = new MySQL.Field(this, "is_platform", "is_platform", MySqlDbType.Bit, false);
				count = new MySQL.Field(this, "count", "count", MySqlDbType.Int32, false);
				overall_count = new MySQL.Field(this, "overall_count", "overall_count", MySqlDbType.Int32, false);
				html_url = new MySQL.Field(this, "html_url", "html_url", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_attribute_type = new MySQL.Field(this, "label_attribute_type", "label_attribute_type", MySqlDbType.VarChar, false);
				label_attribute_value = new MySQL.Field(this, "label_attribute_value", "label_attribute_value", MySqlDbType.VarChar, false);
				label_position = new MySQL.Field(this, "label_position", "label_position", MySqlDbType.VarChar, false);
				datetime = new MySQL.Field(this, "datetime", "datetime", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.Int32, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_title_search_count_2016 : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_word_id;
			public MySQL.Field key_word_name;
			public MySQL.Field release_site_id;
			public MySQL.Field ranking;
			public MySQL.Field position;
			public MySQL.Field url;
			public MySQL.Field search_type;
			public MySQL.Field is_release_site_data;
			public MySQL.Field is_platform;
			public MySQL.Field count;
			public MySQL.Field overall_count;
			public MySQL.Field html_url;
			public MySQL.Field label_type;
			public MySQL.Field label_attribute_type;
			public MySQL.Field label_attribute_value;
			public MySQL.Field label_position;
			public MySQL.Field datetime;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field is_short;
			public MySQL.Field is_erased;

			public t_title_search_count_2016()
			{
				TableName = "t_title_search_count_2016";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				is_release_site_data = new MySQL.Field(this, "is_release_site_data", "is_release_site_data", MySqlDbType.Bit, false);
				is_platform = new MySQL.Field(this, "is_platform", "is_platform", MySqlDbType.Bit, false);
				count = new MySQL.Field(this, "count", "count", MySqlDbType.Int32, false);
				overall_count = new MySQL.Field(this, "overall_count", "overall_count", MySqlDbType.Int32, false);
				html_url = new MySQL.Field(this, "html_url", "html_url", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_attribute_type = new MySQL.Field(this, "label_attribute_type", "label_attribute_type", MySqlDbType.VarChar, false);
				label_attribute_value = new MySQL.Field(this, "label_attribute_value", "label_attribute_value", MySqlDbType.VarChar, false);
				label_position = new MySQL.Field(this, "label_position", "label_position", MySqlDbType.VarChar, false);
				datetime = new MySQL.Field(this, "datetime", "datetime", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.Int32, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_title_search_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_site_id;
			public MySQL.Field keyword;
			public MySQL.Field search_count_id;
			public MySQL.Field ip;
			public MySQL.Field create_time;
			public MySQL.Field product_id;
			public MySQL.Field search_type;
			public MySQL.Field has_ranking;

			public t_title_search_log()
			{
				TableName = "t_title_search_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				search_count_id = new MySQL.Field(this, "search_count_id", "search_count_id", MySqlDbType.Int64, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int32, false);
				has_ranking = new MySQL.Field(this, "has_ranking", "has_ranking", MySqlDbType.Bit, false);
			}
		}

		public class t_title_search_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field key_word_id;
			public MySQL.Field key_word_name;
			public MySQL.Field site_url;
			public MySQL.Field company_name;
			public MySQL.Field company_short_name;
			public MySQL.Field product_id;
			public MySQL.Field trademark;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;
			public MySQL.Field search_type;
			public MySQL.Field type;

			public t_title_search_release()
			{
				TableName = "t_title_search_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				site_url = new MySQL.Field(this, "site_url", "site_url", MySqlDbType.VarChar, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				company_short_name = new MySQL.Field(this, "company_short_name", "company_short_name", MySqlDbType.VarChar, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				trademark = new MySQL.Field(this, "trademark", "trademark", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Bit, false);
			}
		}

		public class t_title_search_release_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field site_id;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field is_erased;

			public t_title_search_release_record()
			{
				TableName = "t_title_search_release_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_title_search_week : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field is_erased;

			public t_title_search_week()
			{
				TableName = "t_title_search_week";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_validatecode : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field configID;
			public MySQL.Field codeUrl;
			public MySQL.Field codeUrlMD5;
			public MySQL.Field code;
			public MySQL.Field addTime;
			public MySQL.Field modifiedTime;
			public MySQL.Field state;
			public MySQL.Field type;
			public MySQL.Field option_eims_id;
			public MySQL.Field code_relatively_path;
			public MySQL.Field code_number;
			public MySQL.Field code_type;

			public t_validatecode()
			{
				TableName = "t_validatecode";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				configID = new MySQL.Field(this, "configID", "configID", MySqlDbType.Int64, false);
				codeUrl = new MySQL.Field(this, "codeUrl", "codeUrl", MySqlDbType.VarChar, false);
				codeUrlMD5 = new MySQL.Field(this, "codeUrlMD5", "codeUrlMD5", MySqlDbType.VarChar, false);
				code = new MySQL.Field(this, "code", "code", MySqlDbType.VarChar, false);
				addTime = new MySQL.Field(this, "addTime", "addTime", MySqlDbType.DateTime, false);
				modifiedTime = new MySQL.Field(this, "modifiedTime", "modifiedTime", MySqlDbType.DateTime, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int32, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int32, false);
				option_eims_id = new MySQL.Field(this, "option_eims_id", "option_eims_id", MySqlDbType.Int64, false);
				code_relatively_path = new MySQL.Field(this, "code_relatively_path", "code_relatively_path", MySqlDbType.VarChar, false);
				code_number = new MySQL.Field(this, "code_number", "code_number", MySqlDbType.Int32, false);
				code_type = new MySQL.Field(this, "code_type", "code_type", MySqlDbType.Int32, false);
			}
		}

		public class t_word2_errorlog : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field product_id;
			public MySQL.Field platform_id;
			public MySQL.Field content;

			public t_word2_errorlog()
			{
				TableName = "t_word2_errorlog";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				platform_id = new MySQL.Field(this, "platform_id", "platform_id", MySqlDbType.Int64, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
			}
		}

		public class t_word2_included_cookie : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field search_engine_type;
			public MySQL.Field content;
			public MySQL.Field ip;

			public t_word2_included_cookie()
			{
				TableName = "t_word2_included_cookie";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				search_engine_type = new MySQL.Field(this, "search_engine_type", "search_engine_type", MySqlDbType.Int32, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
			}
		}

		public class t_word2_included_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field query_time_id;
			public MySQL.Field total_num;
			public MySQL.Field included_num;
			public MySQL.Field not_included_num;

			public t_word2_included_count()
			{
				TableName = "t_word2_included_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				query_time_id = new MySQL.Field(this, "query_time_id", "query_time_id", MySqlDbType.Int64, false);
				total_num = new MySQL.Field(this, "total_num", "total_num", MySqlDbType.Int32, false);
				included_num = new MySQL.Field(this, "included_num", "included_num", MySqlDbType.Int32, false);
				not_included_num = new MySQL.Field(this, "not_included_num", "not_included_num", MySqlDbType.Int32, false);
			}
		}

		public class t_word2_included_detail : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field query_time_id;
			public MySQL.Field platform_artical_id;
			public MySQL.Field url;
			public MySQL.Field title;
			public MySQL.Field is_included;

			public t_word2_included_detail()
			{
				TableName = "t_word2_included_detail";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				query_time_id = new MySQL.Field(this, "query_time_id", "query_time_id", MySqlDbType.Int64, false);
				platform_artical_id = new MySQL.Field(this, "platform_artical_id", "platform_artical_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				is_included = new MySQL.Field(this, "is_included", "is_included", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_included_error_url : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field query_time_id;
			public MySQL.Field platform_artical_id;
			public MySQL.Field url;
			public MySQL.Field title;
			public MySQL.Field query_times;
			public MySQL.Field reason;

			public t_word2_included_error_url()
			{
				TableName = "t_word2_included_error_url";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				query_time_id = new MySQL.Field(this, "query_time_id", "query_time_id", MySqlDbType.Int64, false);
				platform_artical_id = new MySQL.Field(this, "platform_artical_id", "platform_artical_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				query_times = new MySQL.Field(this, "query_times", "query_times", MySqlDbType.Int32, false);
				reason = new MySQL.Field(this, "reason", "reason", MySqlDbType.VarChar, false);
			}
		}

		public class t_word2_included_query_time : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field batch;
			public MySQL.Field query_time;
			public MySQL.Field query_type;
			public MySQL.Field search_engine_type;
			public MySQL.Field begin_id;
			public MySQL.Field end_id;
			public MySQL.Field now_id;
			public MySQL.Field is_finish;
			public MySQL.Field is_finish2;

			public t_word2_included_query_time()
			{
				TableName = "t_word2_included_query_time";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				batch = new MySQL.Field(this, "batch", "batch", MySqlDbType.Int32, false);
				query_time = new MySQL.Field(this, "query_time", "query_time", MySqlDbType.DateTime, false);
				query_type = new MySQL.Field(this, "query_type", "query_type", MySqlDbType.Int32, false);
				search_engine_type = new MySQL.Field(this, "search_engine_type", "search_engine_type", MySqlDbType.Int32, false);
				begin_id = new MySQL.Field(this, "begin_id", "begin_id", MySqlDbType.Int64, false);
				end_id = new MySQL.Field(this, "end_id", "end_id", MySqlDbType.Int64, false);
				now_id = new MySQL.Field(this, "now_id", "now_id", MySqlDbType.Int64, false);
				is_finish = new MySQL.Field(this, "is_finish", "is_finish", MySqlDbType.Bit, false);
				is_finish2 = new MySQL.Field(this, "is_finish2", "is_finish2", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_included_status : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field type;
			public MySQL.Field content;

			public t_word2_included_status()
			{
				TableName = "t_word2_included_status";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.VarChar, false);
			}
		}

		public class t_word2_issue_config : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field begin_days;
			public MySQL.Field end_days;
			public MySQL.Field period;
			public MySQL.Field issue_num;
			public MySQL.Field total_issue_num;
			public MySQL.Field is_erased;

			public t_word2_issue_config()
			{
				TableName = "t_word2_issue_config";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				begin_days = new MySQL.Field(this, "begin_days", "begin_days", MySqlDbType.Int32, false);
				end_days = new MySQL.Field(this, "end_days", "end_days", MySqlDbType.Int32, false);
				period = new MySQL.Field(this, "period", "period", MySqlDbType.Int32, false);
				issue_num = new MySQL.Field(this, "issue_num", "issue_num", MySqlDbType.Int32, false);
				total_issue_num = new MySQL.Field(this, "total_issue_num", "total_issue_num", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_report : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field date1;
			public MySQL.Field site_id;
			public MySQL.Field count_total;
			public MySQL.Field count_lack;

			public t_word2_report()
			{
				TableName = "t_word2_report";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				date1 = new MySQL.Field(this, "date1", "date1", MySqlDbType.VarChar, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				count_total = new MySQL.Field(this, "count_total", "count_total", MySqlDbType.Int32, false);
				count_lack = new MySQL.Field(this, "count_lack", "count_lack", MySqlDbType.Int32, false);
			}
		}

		public class t_word2_sources_site : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field sources_id;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field is_erased;

			public t_word2_sources_site()
			{
				TableName = "t_word2_sources_site";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				sources_id = new MySQL.Field(this, "sources_id", "sources_id", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_synonyms : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field release_site_id;
			public MySQL.Field source_id;
			public MySQL.Field key_word_id;
			public MySQL.Field old_word;
			public MySQL.Field new_word;
			public MySQL.Field is_erased;

			public t_word2_synonyms()
			{
				TableName = "t_word2_synonyms";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				source_id = new MySQL.Field(this, "source_id", "source_id", MySqlDbType.Int64, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				old_word = new MySQL.Field(this, "old_word", "old_word", MySqlDbType.VarChar, false);
				new_word = new MySQL.Field(this, "new_word", "new_word", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_template : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field type;
			public MySQL.Field content;
			public MySQL.Field content_compare;
			public MySQL.Field content_html;
			public MySQL.Field content_html2;
			public MySQL.Field trade_name;
			public MySQL.Field is_erased;

			public t_word2_template()
			{
				TableName = "t_word2_template";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_compare = new MySQL.Field(this, "content_compare", "content_compare", MySqlDbType.Text, false);
				content_html = new MySQL.Field(this, "content_html", "content_html", MySqlDbType.Text, false);
				content_html2 = new MySQL.Field(this, "content_html2", "content_html2", MySqlDbType.Text, false);
				trade_name = new MySQL.Field(this, "trade_name", "trade_name", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_template_mark : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field template_id;
			public MySQL.Field field_id;
			public MySQL.Field list_order;

			public t_word2_template_mark()
			{
				TableName = "t_word2_template_mark";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				template_id = new MySQL.Field(this, "template_id", "template_id", MySqlDbType.Int64, false);
				field_id = new MySQL.Field(this, "field_id", "field_id", MySqlDbType.Int64, false);
				list_order = new MySQL.Field(this, "list_order", "list_order", MySqlDbType.Int32, false);
			}
		}

		public class t_word2_template_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field template_id;
			public MySQL.Field trade_id;

			public t_word2_template_trade()
			{
				TableName = "t_word2_template_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				template_id = new MySQL.Field(this, "template_id", "template_id", MySqlDbType.Int64, false);
				trade_id = new MySQL.Field(this, "trade_id", "trade_id", MySqlDbType.Int64, false);
			}
		}

		public class t_word2_title : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field release_site_id;
			public MySQL.Field product_id;
			public MySQL.Field platform_id;
			public MySQL.Field scs_source_id;
			public MySQL.Field scs_resources_id;
			public MySQL.Field title;
			public MySQL.Field content;
			public MySQL.Field content_head_id;
			public MySQL.Field content_head;
			public MySQL.Field content_middle_id;
			public MySQL.Field content_middle;
			public MySQL.Field content_end_id;
			public MySQL.Field content_end;
			public MySQL.Field is_erased;
			public MySQL.Field key_word_id;
			public MySQL.Field generate_mode;

			public t_word2_title()
			{
				TableName = "t_word2_title";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				platform_id = new MySQL.Field(this, "platform_id", "platform_id", MySqlDbType.Int64, false);
				scs_source_id = new MySQL.Field(this, "scs_source_id", "scs_source_id", MySqlDbType.Int64, false);
				scs_resources_id = new MySQL.Field(this, "scs_resources_id", "scs_resources_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_head_id = new MySQL.Field(this, "content_head_id", "content_head_id", MySqlDbType.Int64, false);
				content_head = new MySQL.Field(this, "content_head", "content_head", MySqlDbType.Text, false);
				content_middle_id = new MySQL.Field(this, "content_middle_id", "content_middle_id", MySqlDbType.Int64, false);
				content_middle = new MySQL.Field(this, "content_middle", "content_middle", MySqlDbType.Text, false);
				content_end_id = new MySQL.Field(this, "content_end_id", "content_end_id", MySqlDbType.Int64, false);
				content_end = new MySQL.Field(this, "content_end", "content_end", MySqlDbType.Text, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				generate_mode = new MySQL.Field(this, "generate_mode", "generate_mode", MySqlDbType.Int16, false);
			}
		}

		public class t_word2_title_del : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field y_id;

			public t_word2_title_del()
			{
				TableName = "t_word2_title_del";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				y_id = new MySQL.Field(this, "y_id", "y_id", MySqlDbType.Int64, false);
			}
		}

		public class t_word2_title_his : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field y_id;
			public MySQL.Field y_create_time;
			public MySQL.Field y_create_user;
			public MySQL.Field y_update_time;
			public MySQL.Field y_update_user;
			public MySQL.Field release_site_id;
			public MySQL.Field product_id;
			public MySQL.Field platform_id;
			public MySQL.Field scs_resources_id;
			public MySQL.Field title;
			public MySQL.Field content;
			public MySQL.Field content_head_id;
			public MySQL.Field content_head;
			public MySQL.Field content_middle_id;
			public MySQL.Field content_middle;
			public MySQL.Field content_end_id;
			public MySQL.Field content_end;
			public MySQL.Field generate_mode;
			public MySQL.Field key_word_id;
			public MySQL.Field is_erased;

			public t_word2_title_his()
			{
				TableName = "t_word2_title_his";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				y_id = new MySQL.Field(this, "y_id", "y_id", MySqlDbType.Int64, false);
				y_create_time = new MySQL.Field(this, "y_create_time", "y_create_time", MySqlDbType.DateTime, false);
				y_create_user = new MySQL.Field(this, "y_create_user", "y_create_user", MySqlDbType.Int64, false);
				y_update_time = new MySQL.Field(this, "y_update_time", "y_update_time", MySqlDbType.DateTime, false);
				y_update_user = new MySQL.Field(this, "y_update_user", "y_update_user", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				platform_id = new MySQL.Field(this, "platform_id", "platform_id", MySqlDbType.Int64, false);
				scs_resources_id = new MySQL.Field(this, "scs_resources_id", "scs_resources_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_head_id = new MySQL.Field(this, "content_head_id", "content_head_id", MySqlDbType.Int64, false);
				content_head = new MySQL.Field(this, "content_head", "content_head", MySqlDbType.Text, false);
				content_middle_id = new MySQL.Field(this, "content_middle_id", "content_middle_id", MySqlDbType.Int64, false);
				content_middle = new MySQL.Field(this, "content_middle", "content_middle", MySqlDbType.Text, false);
				content_end_id = new MySQL.Field(this, "content_end_id", "content_end_id", MySqlDbType.Int64, false);
				content_end = new MySQL.Field(this, "content_end", "content_end", MySqlDbType.Text, false);
				generate_mode = new MySQL.Field(this, "generate_mode", "generate_mode", MySqlDbType.Int32, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word2_title_rewind : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field word2_title_id;
			public MySQL.Field source_id;
			public MySQL.Field resource_id;

			public t_word2_title_rewind()
			{
				TableName = "t_word2_title_rewind";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				word2_title_id = new MySQL.Field(this, "word2_title_id", "word2_title_id", MySqlDbType.Int64, false);
				source_id = new MySQL.Field(this, "source_id", "source_id", MySqlDbType.VarChar, false);
				resource_id = new MySQL.Field(this, "resource_id", "resource_id", MySqlDbType.VarChar, false);
			}
		}

		public class t_word_custom_title : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field product_id;
			public MySQL.Field title;
			public MySQL.Field is_used;
			public MySQL.Field is_erased;

			public t_word_custom_title()
			{
				TableName = "t_word_custom_title";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				is_used = new MySQL.Field(this, "is_used", "is_used", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word_custom_title_temp : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field product_id;
			public MySQL.Field title;
			public MySQL.Field is_used;
			public MySQL.Field is_erased;

			public t_word_custom_title_temp()
			{
				TableName = "t_word_custom_title_temp";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				product_id = new MySQL.Field(this, "product_id", "product_id", MySqlDbType.Int64, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				is_used = new MySQL.Field(this, "is_used", "is_used", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word_custom_title_used : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field custom_title_id;
			public MySQL.Field t_release_id;
			public MySQL.Field t_synth_title_list_id;

			public t_word_custom_title_used()
			{
				TableName = "t_word_custom_title_used";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				custom_title_id = new MySQL.Field(this, "custom_title_id", "custom_title_id", MySqlDbType.Int64, false);
				t_release_id = new MySQL.Field(this, "t_release_id", "t_release_id", MySqlDbType.Int64, false);
				t_synth_title_list_id = new MySQL.Field(this, "t_synth_title_list_id", "t_synth_title_list_id", MySqlDbType.Int64, false);
			}
		}

		public class t_word_issue_config : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field create_user;
			public MySQL.Field update_time;
			public MySQL.Field update_user;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field begin_days;
			public MySQL.Field end_days;
			public MySQL.Field period;
			public MySQL.Field release_num_a;
			public MySQL.Field issue_num_a;
			public MySQL.Field release_num_b;
			public MySQL.Field issue_num_b;
			public MySQL.Field release_num_c;
			public MySQL.Field issue_num_c;
			public MySQL.Field is_erased;

			public t_word_issue_config()
			{
				TableName = "t_word_issue_config";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				create_user = new MySQL.Field(this, "create_user", "create_user", MySqlDbType.Int64, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.DateTime, false);
				update_user = new MySQL.Field(this, "update_user", "update_user", MySqlDbType.Int64, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				begin_days = new MySQL.Field(this, "begin_days", "begin_days", MySqlDbType.Int32, false);
				end_days = new MySQL.Field(this, "end_days", "end_days", MySqlDbType.Int32, false);
				period = new MySQL.Field(this, "period", "period", MySqlDbType.Int32, false);
				release_num_a = new MySQL.Field(this, "release_num_a", "release_num_a", MySqlDbType.Int32, false);
				issue_num_a = new MySQL.Field(this, "issue_num_a", "issue_num_a", MySqlDbType.Int32, false);
				release_num_b = new MySQL.Field(this, "release_num_b", "release_num_b", MySqlDbType.Int32, false);
				issue_num_b = new MySQL.Field(this, "issue_num_b", "issue_num_b", MySqlDbType.Int32, false);
				release_num_c = new MySQL.Field(this, "release_num_c", "release_num_c", MySqlDbType.Int32, false);
				issue_num_c = new MySQL.Field(this, "issue_num_c", "issue_num_c", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_word_issue_selected_resource : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field site_id;
			public MySQL.Field release_site_id;
			public MySQL.Field release_id;

			public t_word_issue_selected_resource()
			{
				TableName = "t_word_issue_selected_resource";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
			}
		}

		public class t_wyzs_app_bank : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field user;
			public MySQL.Field bank;
			public MySQL.Field bank_number;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;
			public MySQL.Field is_bank;

			public t_wyzs_app_bank()
			{
				TableName = "t_wyzs_app_bank";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				user = new MySQL.Field(this, "user", "user", MySqlDbType.VarChar, false);
				bank = new MySQL.Field(this, "bank", "bank", MySqlDbType.VarChar, false);
				bank_number = new MySQL.Field(this, "bank_number", "bank_number", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_bank = new MySQL.Field(this, "is_bank", "is_bank", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_date_money : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field money;
			public MySQL.Field validatecode_money;
			public MySQL.Field validatecode_number;
			public MySQL.Field v_success_number;
			public MySQL.Field v_fail_number;
			public MySQL.Field invite_money;
			public MySQL.Field invite_number;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_date_money()
			{
				TableName = "t_wyzs_app_date_money";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				validatecode_money = new MySQL.Field(this, "validatecode_money", "validatecode_money", MySqlDbType.Decimal, false);
				validatecode_number = new MySQL.Field(this, "validatecode_number", "validatecode_number", MySqlDbType.Int32, false);
				v_success_number = new MySQL.Field(this, "v_success_number", "v_success_number", MySqlDbType.Int32, false);
				v_fail_number = new MySQL.Field(this, "v_fail_number", "v_fail_number", MySqlDbType.Int32, false);
				invite_money = new MySQL.Field(this, "invite_money", "invite_money", MySqlDbType.Decimal, false);
				invite_number = new MySQL.Field(this, "invite_number", "invite_number", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_draw_money : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field bank_id;
			public MySQL.Field money;
			public MySQL.Field state;
			public MySQL.Field serial_number;
			public MySQL.Field remark;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;
			public MySQL.Field fee;
			public MySQL.Field true_fee;
			public MySQL.Field actual_pay;
			public MySQL.Field handle_time;
			public MySQL.Field pay_time;
			public MySQL.Field r_o_id;
			public MySQL.Field pay_succeed_time;

			public t_wyzs_app_draw_money()
			{
				TableName = "t_wyzs_app_draw_money";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				bank_id = new MySQL.Field(this, "bank_id", "bank_id", MySqlDbType.Int64, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				serial_number = new MySQL.Field(this, "serial_number", "serial_number", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				fee = new MySQL.Field(this, "fee", "fee", MySqlDbType.Decimal, false);
				true_fee = new MySQL.Field(this, "true_fee", "true_fee", MySqlDbType.Decimal, false);
				actual_pay = new MySQL.Field(this, "actual_pay", "actual_pay", MySqlDbType.Decimal, false);
				handle_time = new MySQL.Field(this, "handle_time", "handle_time", MySqlDbType.DateTime, false);
				pay_time = new MySQL.Field(this, "pay_time", "pay_time", MySqlDbType.DateTime, false);
				r_o_id = new MySQL.Field(this, "r_o_id", "r_o_id", MySqlDbType.Int64, false);
				pay_succeed_time = new MySQL.Field(this, "pay_succeed_time", "pay_succeed_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_wyzs_app_draw_money_operate : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field serial_number;
			public MySQL.Field sum_money;
			public MySQL.Field man_number;
			public MySQL.Field poundage;
			public MySQL.Field detail;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field payment_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_draw_money_operate()
			{
				TableName = "t_wyzs_app_draw_money_operate";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				serial_number = new MySQL.Field(this, "serial_number", "serial_number", MySqlDbType.VarChar, false);
				sum_money = new MySQL.Field(this, "sum_money", "sum_money", MySqlDbType.Decimal, false);
				man_number = new MySQL.Field(this, "man_number", "man_number", MySqlDbType.Int32, false);
				poundage = new MySQL.Field(this, "poundage", "poundage", MySqlDbType.Decimal, false);
				detail = new MySQL.Field(this, "detail", "detail", MySqlDbType.Text, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				payment_time = new MySQL.Field(this, "payment_time", "payment_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_imei : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_id;
			public MySQL.Field eims_id;
			public MySQL.Field mobile_type;
			public MySQL.Field mobile;
			public MySQL.Field imei;
			public MySQL.Field create_time;

			public t_wyzs_app_imei()
			{
				TableName = "t_wyzs_app_imei";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				mobile_type = new MySQL.Field(this, "mobile_type", "mobile_type", MySqlDbType.Bit, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				imei = new MySQL.Field(this, "imei", "imei", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_wyzs_app_introduction : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field content;
			public MySQL.Field html_content;
			public MySQL.Field html_path;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_introduction()
			{
				TableName = "t_wyzs_app_introduction";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				html_content = new MySQL.Field(this, "html_content", "html_content", MySqlDbType.Text, false);
				html_path = new MySQL.Field(this, "html_path", "html_path", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_invite : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field passive_app_user_id;
			public MySQL.Field passive_eims_id;
			public MySQL.Field imei;
			public MySQL.Field source;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_invite()
			{
				TableName = "t_wyzs_app_invite";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				passive_app_user_id = new MySQL.Field(this, "passive_app_user_id", "passive_app_user_id", MySqlDbType.Int64, false);
				passive_eims_id = new MySQL.Field(this, "passive_eims_id", "passive_eims_id", MySqlDbType.Int64, false);
				imei = new MySQL.Field(this, "imei", "imei", MySqlDbType.VarChar, false);
				source = new MySQL.Field(this, "source", "source", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_login : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_login()
			{
				TableName = "t_wyzs_app_login";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_message : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field release_id;
			public MySQL.Field app_user_id;
			public MySQL.Field mobile;
			public MySQL.Field eims_id;
			public MySQL.Field imei;
			public MySQL.Field code;
			public MySQL.Field addTime;
			public MySQL.Field modifiedTime;
			public MySQL.Field state;
			public MySQL.Field type;

			public t_wyzs_app_message()
			{
				TableName = "t_wyzs_app_message";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				release_id = new MySQL.Field(this, "release_id", "release_id", MySqlDbType.Int64, false);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				imei = new MySQL.Field(this, "imei", "imei", MySqlDbType.VarChar, false);
				code = new MySQL.Field(this, "code", "code", MySqlDbType.VarChar, false);
				addTime = new MySQL.Field(this, "addTime", "addTime", MySqlDbType.DateTime, false);
				modifiedTime = new MySQL.Field(this, "modifiedTime", "modifiedTime", MySqlDbType.DateTime, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int32, false);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int32, false);
			}
		}

		public class t_wyzs_app_retransmission : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field source;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_retransmission()
			{
				TableName = "t_wyzs_app_retransmission";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				source = new MySQL.Field(this, "source", "source", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_site_mobile : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field site_id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field mobile;
			public MySQL.Field imei;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_site_mobile()
			{
				TableName = "t_wyzs_app_site_mobile";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				site_id = new MySQL.Field(this, "site_id", "site_id", MySqlDbType.Int64, false);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				imei = new MySQL.Field(this, "imei", "imei", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_sms_record : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field app_site_mobile_id;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_sms_record()
			{
				TableName = "t_wyzs_app_sms_record";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				app_site_mobile_id = new MySQL.Field(this, "app_site_mobile_id", "app_site_mobile_id", MySqlDbType.Int64, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int32, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_type : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field type;
			public MySQL.Field money;
			public MySQL.Field create_time;
			public MySQL.Field update_time;

			public t_wyzs_app_type()
			{
				TableName = "t_wyzs_app_type";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				type = new MySQL.Field(this, "type", "type", MySqlDbType.Int24, false);
				money = new MySQL.Field(this, "money", "money", MySqlDbType.Decimal, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
			}
		}

		public class t_wyzs_app_upgrade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field version_number;
			public MySQL.Field title;
			public MySQL.Field version_1;
			public MySQL.Field version_2;
			public MySQL.Field version_3;
			public MySQL.Field html_path;
			public MySQL.Field content;
			public MySQL.Field content_html;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;
			public MySQL.Field is_force;

			public t_wyzs_app_upgrade()
			{
				TableName = "t_wyzs_app_upgrade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				version_number = new MySQL.Field(this, "version_number", "version_number", MySqlDbType.VarChar, false);
				title = new MySQL.Field(this, "title", "title", MySqlDbType.VarChar, false);
				version_1 = new MySQL.Field(this, "version_1", "version_1", MySqlDbType.Int32, false);
				version_2 = new MySQL.Field(this, "version_2", "version_2", MySqlDbType.Int32, false);
				version_3 = new MySQL.Field(this, "version_3", "version_3", MySqlDbType.Int32, false);
				html_path = new MySQL.Field(this, "html_path", "html_path", MySqlDbType.VarChar, false);
				content = new MySQL.Field(this, "content", "content", MySqlDbType.Text, false);
				content_html = new MySQL.Field(this, "content_html", "content_html", MySqlDbType.Text, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				is_force = new MySQL.Field(this, "is_force", "is_force", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_user : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field application_id;
			public MySQL.Field instance_id;
			public MySQL.Field eims_id;
			public MySQL.Field password;
			public MySQL.Field md5_password;
			public MySQL.Field nickname;
			public MySQL.Field name;
			public MySQL.Field company;
			public MySQL.Field industry;
			public MySQL.Field sex;
			public MySQL.Field email;
			public MySQL.Field qq;
			public MySQL.Field mobile;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_user()
			{
				TableName = "t_wyzs_app_user";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				application_id = new MySQL.Field(this, "application_id", "application_id", MySqlDbType.Int64, false);
				instance_id = new MySQL.Field(this, "instance_id", "instance_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				password = new MySQL.Field(this, "password", "password", MySqlDbType.VarChar, false);
				md5_password = new MySQL.Field(this, "md5_password", "md5_password", MySqlDbType.VarChar, false);
				nickname = new MySQL.Field(this, "nickname", "nickname", MySqlDbType.VarChar, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				company = new MySQL.Field(this, "company", "company", MySqlDbType.VarChar, false);
				industry = new MySQL.Field(this, "industry", "industry", MySqlDbType.VarChar, false);
				sex = new MySQL.Field(this, "sex", "sex", MySqlDbType.Bit, false);
				email = new MySQL.Field(this, "email", "email", MySqlDbType.VarChar, false);
				qq = new MySQL.Field(this, "qq", "qq", MySqlDbType.VarChar, false);
				mobile = new MySQL.Field(this, "mobile", "mobile", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_wyzs_app_validatecode : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field validatecode_id;
			public MySQL.Field app_user_id;
			public MySQL.Field eims_id;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field is_erased;

			public t_wyzs_app_validatecode()
			{
				TableName = "t_wyzs_app_validatecode";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				validatecode_id = new MySQL.Field(this, "validatecode_id", "validatecode_id", MySqlDbType.Int64, false);
				app_user_id = new MySQL.Field(this, "app_user_id", "app_user_id", MySqlDbType.Int64, false);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field eims_id;
			public MySQL.Field url_id;
			public MySQL.Field url;
			public MySQL.Field ip;
			public MySQL.Field company_name;
			public MySQL.Field domain_name;
			public MySQL.Field url_type;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain()
			{
				TableName = "t_yl_cloud_chain";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				eims_id = new MySQL.Field(this, "eims_id", "eims_id", MySqlDbType.Int64, false);
				url_id = new MySQL.Field(this, "url_id", "url_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				company_name = new MySQL.Field(this, "company_name", "company_name", MySqlDbType.VarChar, false);
				domain_name = new MySQL.Field(this, "domain_name", "domain_name", MySqlDbType.VarChar, false);
				url_type = new MySQL.Field(this, "url_type", "url_type", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_inner : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_word;
			public MySQL.Field url;
			public MySQL.Field ip;
			public MySQL.Field pr;
			public MySQL.Field remark;
			public MySQL.Field cloud_chain_trade_id;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_inner()
			{
				TableName = "t_yl_cloud_chain_inner";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_word = new MySQL.Field(this, "key_word", "key_word", MySqlDbType.VarChar, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				pr = new MySQL.Field(this, "pr", "pr", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				cloud_chain_trade_id = new MySQL.Field(this, "cloud_chain_trade_id", "cloud_chain_trade_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_key_word : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cloud_chain_id;
			public MySQL.Field key_word;
			public MySQL.Field remark;
			public MySQL.Field cloud_chain_trade_id;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_key_word()
			{
				TableName = "t_yl_cloud_chain_key_word";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cloud_chain_id = new MySQL.Field(this, "cloud_chain_id", "cloud_chain_id", MySqlDbType.Int64, false);
				key_word = new MySQL.Field(this, "key_word", "key_word", MySqlDbType.VarChar, false);
				remark = new MySQL.Field(this, "remark", "remark", MySqlDbType.VarChar, false);
				cloud_chain_trade_id = new MySQL.Field(this, "cloud_chain_trade_id", "cloud_chain_trade_id", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_month : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field week;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_month()
			{
				TableName = "t_yl_cloud_chain_month";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				week = new MySQL.Field(this, "week", "week", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_pr : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field cloud_chain_id;
			public MySQL.Field pr;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_pr()
			{
				TableName = "t_yl_cloud_chain_pr";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				cloud_chain_id = new MySQL.Field(this, "cloud_chain_id", "cloud_chain_id", MySqlDbType.Int64, false);
				pr = new MySQL.Field(this, "pr", "pr", MySqlDbType.Int32, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_pr_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field chain_id;
			public MySQL.Field url;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;

			public t_yl_cloud_chain_pr_release()
			{
				TableName = "t_yl_cloud_chain_pr_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				chain_id = new MySQL.Field(this, "chain_id", "chain_id", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_yl_cloud_chain_pr_week : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_pr_week()
			{
				TableName = "t_yl_cloud_chain_pr_week";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_relation : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field chain_id;
			public MySQL.Field key_word_id;
			public MySQL.Field apply_chain_id;
			public MySQL.Field apply_key_word_id;
			public MySQL.Field is_apply;
			public MySQL.Field state;
			public MySQL.Field is_erased;
			public MySQL.Field create_time;
			public MySQL.Field update_time;
			public MySQL.Field remarks;

			public t_yl_cloud_chain_relation()
			{
				TableName = "t_yl_cloud_chain_relation";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				chain_id = new MySQL.Field(this, "chain_id", "chain_id", MySqlDbType.Int64, false);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				apply_chain_id = new MySQL.Field(this, "apply_chain_id", "apply_chain_id", MySqlDbType.Int64, false);
				apply_key_word_id = new MySQL.Field(this, "apply_key_word_id", "apply_key_word_id", MySqlDbType.Int64, false);
				is_apply = new MySQL.Field(this, "is_apply", "is_apply", MySqlDbType.Bit, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				update_time = new MySQL.Field(this, "update_time", "update_time", MySqlDbType.Timestamp, false);
				remarks = new MySQL.Field(this, "remarks", "remarks", MySqlDbType.VarChar, false);
			}
		}

		public class t_yl_cloud_chain_search_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field key_word_id;
			public MySQL.Field key_word_name;
			public MySQL.Field chain_id;
			public MySQL.Field ranking;
			public MySQL.Field position;
			public MySQL.Field url;
			public MySQL.Field search_type;
			public MySQL.Field is_release_site_data;
			public MySQL.Field count;
			public MySQL.Field overall_count;
			public MySQL.Field html_url;
			public MySQL.Field label_type;
			public MySQL.Field label_attribute_type;
			public MySQL.Field label_attribute_value;
			public MySQL.Field label_position;
			public MySQL.Field datetime;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field is_short;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_search_count()
			{
				TableName = "t_yl_cloud_chain_search_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				key_word_id = new MySQL.Field(this, "key_word_id", "key_word_id", MySqlDbType.Int64, false);
				key_word_name = new MySQL.Field(this, "key_word_name", "key_word_name", MySqlDbType.VarChar, false);
				chain_id = new MySQL.Field(this, "chain_id", "chain_id", MySqlDbType.Int64, false);
				ranking = new MySQL.Field(this, "ranking", "ranking", MySqlDbType.Int32, false);
				position = new MySQL.Field(this, "position", "position", MySqlDbType.Int32, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				search_type = new MySQL.Field(this, "search_type", "search_type", MySqlDbType.Int24, false);
				is_release_site_data = new MySQL.Field(this, "is_release_site_data", "is_release_site_data", MySqlDbType.Bit, false);
				count = new MySQL.Field(this, "count", "count", MySqlDbType.Int32, false);
				overall_count = new MySQL.Field(this, "overall_count", "overall_count", MySqlDbType.Int32, false);
				html_url = new MySQL.Field(this, "html_url", "html_url", MySqlDbType.VarChar, false);
				label_type = new MySQL.Field(this, "label_type", "label_type", MySqlDbType.VarChar, false);
				label_attribute_type = new MySQL.Field(this, "label_attribute_type", "label_attribute_type", MySqlDbType.VarChar, false);
				label_attribute_value = new MySQL.Field(this, "label_attribute_value", "label_attribute_value", MySqlDbType.VarChar, false);
				label_position = new MySQL.Field(this, "label_position", "label_position", MySqlDbType.VarChar, false);
				datetime = new MySQL.Field(this, "datetime", "datetime", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.Int32, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.Int32, false);
				is_short = new MySQL.Field(this, "is_short", "is_short", MySqlDbType.Bit, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_search_release : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field chain_id;
			public MySQL.Field state;
			public MySQL.Field create_time;
			public MySQL.Field pull_time;

			public t_yl_cloud_chain_search_release()
			{
				TableName = "t_yl_cloud_chain_search_release";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				chain_id = new MySQL.Field(this, "chain_id", "chain_id", MySqlDbType.Int64, false);
				state = new MySQL.Field(this, "state", "state", MySqlDbType.Int24, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_yl_cloud_chain_search_week : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field is_erased;

			public t_yl_cloud_chain_search_week()
			{
				TableName = "t_yl_cloud_chain_search_week";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yl_cloud_chain_trade : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field parent_id;
			public MySQL.Field name;
			public MySQL.Field code;
			public MySQL.Field description;
			public MySQL.Field order;
			public MySQL.Field is_use;
			public MySQL.Field data_version;
			public MySQL.Field click_count;

			public t_yl_cloud_chain_trade()
			{
				TableName = "t_yl_cloud_chain_trade";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int32, false);
				name = new MySQL.Field(this, "name", "name", MySqlDbType.VarChar, false);
				code = new MySQL.Field(this, "code", "code", MySqlDbType.VarChar, false);
				description = new MySQL.Field(this, "description", "description", MySqlDbType.LongText, false);
				order = new MySQL.Field(this, "order", "order", MySqlDbType.Int32, false);
				is_use = new MySQL.Field(this, "is_use", "is_use", MySqlDbType.Bit, false);
				data_version = new MySQL.Field(this, "data_version", "data_version", MySqlDbType.Int64, false);
				click_count = new MySQL.Field(this, "click_count", "click_count", MySqlDbType.Int64, false);
			}
		}

		public class t_yz_cloud_click_task : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field execution_time;
			public MySQL.Field t_yz_cloud_keyword_id;
			public MySQL.Field keyword;
			public MySQL.Field ip;
			public MySQL.Field ip_code;
			public MySQL.Field url;
			public MySQL.Field release_site_id;
			public MySQL.Field user_id;
			public MySQL.Field pull_time;

			public t_yz_cloud_click_task()
			{
				TableName = "t_yz_cloud_click_task";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				execution_time = new MySQL.Field(this, "execution_time", "execution_time", MySqlDbType.DateTime, false);
				t_yz_cloud_keyword_id = new MySQL.Field(this, "t_yz_cloud_keyword_id", "t_yz_cloud_keyword_id", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				ip_code = new MySQL.Field(this, "ip_code", "ip_code", MySqlDbType.Int64, false);
				url = new MySQL.Field(this, "url", "url", MySqlDbType.VarChar, false);
				release_site_id = new MySQL.Field(this, "release_site_id", "release_site_id", MySqlDbType.Int64, false);
				user_id = new MySQL.Field(this, "user_id", "user_id", MySqlDbType.Int64, false);
				pull_time = new MySQL.Field(this, "pull_time", "pull_time", MySqlDbType.DateTime, false);
			}
		}

		public class t_yz_cloud_content : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field web_site;
			public MySQL.Field web_name;
			public MySQL.Field userid;
			public MySQL.Field t_synth_release_site_id;
			public MySQL.Field create_time;
			public MySQL.Field is_erased;

			public t_yz_cloud_content()
			{
				TableName = "t_yz_cloud_content";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				web_site = new MySQL.Field(this, "web_site", "web_site", MySqlDbType.VarChar, false);
				web_name = new MySQL.Field(this, "web_name", "web_name", MySqlDbType.VarChar, false);
				userid = new MySQL.Field(this, "userid", "userid", MySqlDbType.Int64, false);
				t_synth_release_site_id = new MySQL.Field(this, "t_synth_release_site_id", "t_synth_release_site_id", MySqlDbType.Int64, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yz_cloud_count : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field t_yz_cloud_keyword_id;
			public MySQL.Field click_count;

			public t_yz_cloud_count()
			{
				TableName = "t_yz_cloud_count";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				t_yz_cloud_keyword_id = new MySQL.Field(this, "t_yz_cloud_keyword_id", "t_yz_cloud_keyword_id", MySqlDbType.Int32, false);
				click_count = new MySQL.Field(this, "click_count", "click_count", MySqlDbType.Int32, false);
			}
		}

		public class t_yz_cloud_day : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field count_time;
			public MySQL.Field year;
			public MySQL.Field month;
			public MySQL.Field day;
			public MySQL.Field is_erased;

			public t_yz_cloud_day()
			{
				TableName = "t_yz_cloud_day";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				count_time = new MySQL.Field(this, "count_time", "count_time", MySqlDbType.DateTime, false);
				year = new MySQL.Field(this, "year", "year", MySqlDbType.VarChar, false);
				month = new MySQL.Field(this, "month", "month", MySqlDbType.VarChar, false);
				day = new MySQL.Field(this, "day", "day", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}

		public class t_yz_cloud_execution : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field execution_time;
			public MySQL.Field t_yz_cloud_keyword_id;
			public MySQL.Field relationId;
			public MySQL.Field is_grab;

			public t_yz_cloud_execution()
			{
				TableName = "t_yz_cloud_execution";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				execution_time = new MySQL.Field(this, "execution_time", "execution_time", MySqlDbType.DateTime, false);
				t_yz_cloud_keyword_id = new MySQL.Field(this, "t_yz_cloud_keyword_id", "t_yz_cloud_keyword_id", MySqlDbType.Int64, false);
				relationId = new MySQL.Field(this, "relationId", "relationId", MySqlDbType.Int64, false);
				is_grab = new MySQL.Field(this, "is_grab", "is_grab", MySqlDbType.Int64, false);
			}
		}

		public class t_yz_cloud_ip_log : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field create_time;
			public MySQL.Field ip_address;
			public MySQL.Field keyword;
			public MySQL.Field domainname;
			public MySQL.Field is_erased;

			public t_yz_cloud_ip_log()
			{
				TableName = "t_yz_cloud_ip_log";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				ip_address = new MySQL.Field(this, "ip_address", "ip_address", MySqlDbType.VarChar, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				domainname = new MySQL.Field(this, "domainname", "domainname", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Int64, false);
			}
		}

		public class t_yz_cloud_keyword : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field day_click;
			public MySQL.Field t_wyzc_yz_content_id;
			public MySQL.Field open_time;
			public MySQL.Field now_state;
			public MySQL.Field keyword;
			public MySQL.Field is_erased;
			public MySQL.Field examincontent;
			public MySQL.Field clickcount;

			public t_yz_cloud_keyword()
			{
				TableName = "t_yz_cloud_keyword";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				day_click = new MySQL.Field(this, "day_click", "day_click", MySqlDbType.Int64, false);
				t_wyzc_yz_content_id = new MySQL.Field(this, "t_wyzc_yz_content_id", "t_wyzc_yz_content_id", MySqlDbType.Int64, false);
				open_time = new MySQL.Field(this, "open_time", "open_time", MySqlDbType.DateTime, false);
				now_state = new MySQL.Field(this, "now_state", "now_state", MySqlDbType.Int64, false);
				keyword = new MySQL.Field(this, "keyword", "keyword", MySqlDbType.VarChar, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
				examincontent = new MySQL.Field(this, "examincontent", "examincontent", MySqlDbType.VarChar, false);
				clickcount = new MySQL.Field(this, "clickcount", "clickcount", MySqlDbType.Int64, false);
			}
		}

		public class t_yz_cloud_logmanage : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field user_agent;
			public MySQL.Field cookie;
			public MySQL.Field ip;
			public MySQL.Field t_yz_cloud_ranking_id;
			public MySQL.Field record_time;
			public MySQL.Field server_time;
			public MySQL.Field clickurl;
			public MySQL.Field parent_id;
			public MySQL.Field status;
			public MySQL.Field content_id;
			public MySQL.Field t_synth_release_site_id;
			public MySQL.Field keyword_id;

			public t_yz_cloud_logmanage()
			{
				TableName = "t_yz_cloud_logmanage";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				user_agent = new MySQL.Field(this, "user_agent", "user_agent", MySqlDbType.VarChar, false);
				cookie = new MySQL.Field(this, "cookie", "cookie", MySqlDbType.VarChar, false);
				ip = new MySQL.Field(this, "ip", "ip", MySqlDbType.VarChar, false);
				t_yz_cloud_ranking_id = new MySQL.Field(this, "t_yz_cloud_ranking_id", "t_yz_cloud_ranking_id", MySqlDbType.Int32, false);
				record_time = new MySQL.Field(this, "record_time", "record_time", MySqlDbType.DateTime, false);
				server_time = new MySQL.Field(this, "server_time", "server_time", MySqlDbType.DateTime, false);
				clickurl = new MySQL.Field(this, "clickurl", "clickurl", MySqlDbType.Text, false);
				parent_id = new MySQL.Field(this, "parent_id", "parent_id", MySqlDbType.Int64, false);
				status = new MySQL.Field(this, "status", "status", MySqlDbType.Int32, false);
				content_id = new MySQL.Field(this, "content_id", "content_id", MySqlDbType.Int64, false);
				t_synth_release_site_id = new MySQL.Field(this, "t_synth_release_site_id", "t_synth_release_site_id", MySqlDbType.Int64, false);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int64, false);
			}
		}

		public class t_yz_cloud_ranking : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field t_yz_cloud_keyword_id;
			public MySQL.Field site_ranking;
			public MySQL.Field site_position;
			public MySQL.Field last_week_ranking;
			public MySQL.Field last_week_position;

			public t_yz_cloud_ranking()
			{
				TableName = "t_yz_cloud_ranking";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int64, true);
				t_yz_cloud_keyword_id = new MySQL.Field(this, "t_yz_cloud_keyword_id", "t_yz_cloud_keyword_id", MySqlDbType.Int64, false);
				site_ranking = new MySQL.Field(this, "site_ranking", "site_ranking", MySqlDbType.Int64, false);
				site_position = new MySQL.Field(this, "site_position", "site_position", MySqlDbType.VarChar, false);
				last_week_ranking = new MySQL.Field(this, "last_week_ranking", "last_week_ranking", MySqlDbType.Int64, false);
				last_week_position = new MySQL.Field(this, "last_week_position", "last_week_position", MySqlDbType.VarChar, false);
			}
		}

		public class t_yz_cloud_tasklist : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field click_number;
			public MySQL.Field timeslot_id;
			public MySQL.Field keyword_id;

			public t_yz_cloud_tasklist()
			{
				TableName = "t_yz_cloud_tasklist";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				click_number = new MySQL.Field(this, "click_number", "click_number", MySqlDbType.Int32, false);
				timeslot_id = new MySQL.Field(this, "timeslot_id", "timeslot_id", MySqlDbType.Int32, false);
				keyword_id = new MySQL.Field(this, "keyword_id", "keyword_id", MySqlDbType.Int32, false);
			}
		}

		public class t_yz_cloud_timeslot : MySQL.TableBase
		{
			public MySQL.Field id;
			public MySQL.Field time_range;
			public MySQL.Field create_time;
			public MySQL.Field sort;
			public MySQL.Field is_erased;

			public t_yz_cloud_timeslot()
			{
				TableName = "t_yz_cloud_timeslot";

				id = new MySQL.Field(this, "id", "id", MySqlDbType.Int32, true);
				time_range = new MySQL.Field(this, "time_range", "time_range", MySqlDbType.VarChar, false);
				create_time = new MySQL.Field(this, "create_time", "create_time", MySqlDbType.DateTime, false);
				sort = new MySQL.Field(this, "sort", "sort", MySqlDbType.Int64, false);
				is_erased = new MySQL.Field(this, "is_erased", "is_erased", MySqlDbType.Bit, false);
			}
		}
	}

	public class Views
	{
		public class title_product_site : MySQL.ViewBase
		{
			public title_product_site()
			{
				ViewName = "title_product_site";
			}
		}

		public class view_advertisingplanaudit : MySQL.ViewBase
		{
			public view_advertisingplanaudit()
			{
				ViewName = "view_advertisingplanaudit";
			}
		}

		public class view_bankcard : MySQL.ViewBase
		{
			public view_bankcard()
			{
				ViewName = "view_bankcard";
			}
		}

		public class view_commonproblem : MySQL.ViewBase
		{
			public view_commonproblem()
			{
				ViewName = "view_commonproblem";
			}
		}

		public class view_companyaudit : MySQL.ViewBase
		{
			public view_companyaudit()
			{
				ViewName = "view_companyaudit";
			}
		}

		public class view_industryall : MySQL.ViewBase
		{
			public view_industryall()
			{
				ViewName = "view_industryall";
			}
		}

		public class view_industryfour : MySQL.ViewBase
		{
			public view_industryfour()
			{
				ViewName = "view_industryfour";
			}
		}

		public class view_industryone : MySQL.ViewBase
		{
			public view_industryone()
			{
				ViewName = "view_industryone";
			}
		}

		public class view_industrythree : MySQL.ViewBase
		{
			public view_industrythree()
			{
				ViewName = "view_industrythree";
			}
		}

		public class view_industrytwo : MySQL.ViewBase
		{
			public view_industrytwo()
			{
				ViewName = "view_industrytwo";
			}
		}

		public class view_productaudit : MySQL.ViewBase
		{
			public view_productaudit()
			{
				ViewName = "view_productaudit";
			}
		}

		public class view_release_user_select : MySQL.ViewBase
		{
			public view_release_user_select()
			{
				ViewName = "view_release_user_select";
			}
		}

		public class view_resourcesall : MySQL.ViewBase
		{
			public view_resourcesall()
			{
				ViewName = "view_resourcesall";
			}
		}

		public class view_siteidentification : MySQL.ViewBase
		{
			public view_siteidentification()
			{
				ViewName = "view_siteidentification";
			}
		}

		public class view_tamall : MySQL.ViewBase
		{
			public view_tamall()
			{
				ViewName = "view_tamall";
			}
		}

		public class view_tpmall : MySQL.ViewBase
		{
			public view_tpmall()
			{
				ViewName = "view_tpmall";
			}
		}

		public class view_tpmfive : MySQL.ViewBase
		{
			public view_tpmfive()
			{
				ViewName = "view_tpmfive";
			}
		}

		public class view_tpmfour : MySQL.ViewBase
		{
			public view_tpmfour()
			{
				ViewName = "view_tpmfour";
			}
		}

		public class view_tpmone : MySQL.ViewBase
		{
			public view_tpmone()
			{
				ViewName = "view_tpmone";
			}
		}

		public class view_tpmthree : MySQL.ViewBase
		{
			public view_tpmthree()
			{
				ViewName = "view_tpmthree";
			}
		}

		public class view_tpmtwo : MySQL.ViewBase
		{
			public view_tpmtwo()
			{
				ViewName = "view_tpmtwo";
			}
		}

		public class view_t_synth_news : MySQL.ViewBase
		{
			public view_t_synth_news()
			{
				ViewName = "view_t_synth_news";
			}
		}

		public class view_withdrawals : MySQL.ViewBase
		{
			public view_withdrawals()
			{
				ViewName = "view_withdrawals";
			}
		}

		public class view_wrodall : MySQL.ViewBase
		{
			public view_wrodall()
			{
				ViewName = "view_wrodall";
			}
		}

		public class view_yz_cloud_execution : MySQL.ViewBase
		{
			public view_yz_cloud_execution()
			{
				ViewName = "view_yz_cloud_execution";
			}
		}

		public class view_yz_cloud_logmange : MySQL.ViewBase
		{
			public view_yz_cloud_logmange()
			{
				ViewName = "view_yz_cloud_logmange";
			}
		}

		public class view_yz_cloud_release_site : MySQL.ViewBase
		{
			public view_yz_cloud_release_site()
			{
				ViewName = "view_yz_cloud_release_site";
			}
		}

		public class v_area : MySQL.ViewBase
		{
			public v_area()
			{
				ViewName = "v_area";
			}
		}

		public class v_contentrule_columtorow : MySQL.ViewBase
		{
			public v_contentrule_columtorow()
			{
				ViewName = "v_contentrule_columtorow";
			}
		}

		public class v_content_cate : MySQL.ViewBase
		{
			public v_content_cate()
			{
				ViewName = "v_content_cate";
			}
		}

		public class v_lucenes : MySQL.ViewBase
		{
			public v_lucenes()
			{
				ViewName = "v_lucenes";
			}
		}

		public class v_synth_field : MySQL.ViewBase
		{
			public v_synth_field()
			{
				ViewName = "v_synth_field";
			}
		}

		public class v_synth_field_alias : MySQL.ViewBase
		{
			public v_synth_field_alias()
			{
				ViewName = "v_synth_field_alias";
			}
		}

		public class v_synth_field_word : MySQL.ViewBase
		{
			public v_synth_field_word()
			{
				ViewName = "v_synth_field_word";
			}
		}

		public class v_synth_key_word_use : MySQL.ViewBase
		{
			public v_synth_key_word_use()
			{
				ViewName = "v_synth_key_word_use";
			}
		}

		public class v_synth_para_list : MySQL.ViewBase
		{
			public v_synth_para_list()
			{
				ViewName = "v_synth_para_list";
			}
		}

		public class v_synth_product_value : MySQL.ViewBase
		{
			public v_synth_product_value()
			{
				ViewName = "v_synth_product_value";
			}
		}

		public class v_urlinfo_category : MySQL.ViewBase
		{
			public v_urlinfo_category()
			{
				ViewName = "v_urlinfo_category";
			}
		}

		public class v_urlinfo_rule : MySQL.ViewBase
		{
			public v_urlinfo_rule()
			{
				ViewName = "v_urlinfo_rule";
			}
		}

		public class v_urlrule_category : MySQL.ViewBase
		{
			public v_urlrule_category()
			{
				ViewName = "v_urlrule_category";
			}
		}

		public class v_yz_cloud_clickcloudinfo : MySQL.ViewBase
		{
			public v_yz_cloud_clickcloudinfo()
			{
				ViewName = "v_yz_cloud_clickcloudinfo";
			}
		}

		public class v_yz_cloud_keywordexamine : MySQL.ViewBase
		{
			public v_yz_cloud_keywordexamine()
			{
				ViewName = "v_yz_cloud_keywordexamine";
			}
		}

		public class v_yz_cloud_keywordlist : MySQL.ViewBase
		{
			public v_yz_cloud_keywordlist()
			{
				ViewName = "v_yz_cloud_keywordlist";
			}
		}

		public class v_yz_cloud_keywordranking : MySQL.ViewBase
		{
			public v_yz_cloud_keywordranking()
			{
				ViewName = "v_yz_cloud_keywordranking";
			}
		}

		public class v_yz_cloud_logmanage : MySQL.ViewBase
		{
			public v_yz_cloud_logmanage()
			{
				ViewName = "v_yz_cloud_logmanage";
			}
		}

		public class v_yz_cloud_praiselist : MySQL.ViewBase
		{
			public v_yz_cloud_praiselist()
			{
				ViewName = "v_yz_cloud_praiselist";
			}
		}

		public class yl_cloud_chain_word : MySQL.ViewBase
		{
			public yl_cloud_chain_word()
			{
				ViewName = "yl_cloud_chain_word";
			}
		}

		public class yz_cloud_release_site : MySQL.ViewBase
		{
			public yz_cloud_release_site()
			{
				ViewName = "yz_cloud_release_site";
			}
		}
	}

	public class Functions
	{
		public static string GetNum(string Varstring)
		{
			object Result = MySQL.ExecuteFunction("GetNum",
				new MySQL.Parameter("Varstring", MySqlDbType.VarChar, 0, ParameterDirection.Input, Varstring));

			return System.Convert.ToString(Result);
		}
	}

	public class Procedures
	{
		public static int esc()
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureNonQuery("esc", ref Outputs
				);

			return CallResult;
		}

		public static int esc(ref DataSet ds)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureWithQuery("esc", ref ds, ref Outputs
				);

			return CallResult;
		}

		public static int esc2()
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureNonQuery("esc2", ref Outputs
				);

			return CallResult;
		}

		public static int esc2(ref DataSet ds)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureWithQuery("esc2", ref ds, ref Outputs
				);

			return CallResult;
		}

		public static int Query_Page(string _fields, string _tables, string _where, string _orderby, int _pageindex, int _pagesize, string _sumfields, ref int _totalcount, ref int _pagecount)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureNonQuery("Query_Page", ref Outputs,
				new MySQL.Parameter("_fields", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _fields),
				new MySQL.Parameter("_tables", MySqlDbType.Text, 0, ParameterDirection.Input, _tables),
				new MySQL.Parameter("_where", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _where),
				new MySQL.Parameter("_orderby", MySqlDbType.VarChar, 200, ParameterDirection.Input, _orderby),
				new MySQL.Parameter("_pageindex", MySqlDbType.Int32, 0, ParameterDirection.Input, _pageindex),
				new MySQL.Parameter("_pagesize", MySqlDbType.Int32, 0, ParameterDirection.Input, _pagesize),
				new MySQL.Parameter("_sumfields", MySqlDbType.VarChar, 200, ParameterDirection.Input, _sumfields),
				new MySQL.Parameter("_totalcount", MySqlDbType.Int32, 0, ParameterDirection.Output, _totalcount),
				new MySQL.Parameter("_pagecount", MySqlDbType.Int32, 0, ParameterDirection.Output, _pagecount)
				);

			try
			{
				_totalcount = System.Convert.ToInt32(Outputs["_totalcount"]);
			}
			catch { }

			try
			{
				_pagecount = System.Convert.ToInt32(Outputs["_pagecount"]);
			}
			catch { }

			return CallResult;
		}

		public static int Query_Page(ref DataSet ds, string _fields, string _tables, string _where, string _orderby, int _pageindex, int _pagesize, string _sumfields, ref int _totalcount, ref int _pagecount)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureWithQuery("Query_Page", ref ds, ref Outputs,
				new MySQL.Parameter("_fields", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _fields),
				new MySQL.Parameter("_tables", MySqlDbType.Text, 0, ParameterDirection.Input, _tables),
				new MySQL.Parameter("_where", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _where),
				new MySQL.Parameter("_orderby", MySqlDbType.VarChar, 200, ParameterDirection.Input, _orderby),
				new MySQL.Parameter("_pageindex", MySqlDbType.Int32, 0, ParameterDirection.Input, _pageindex),
				new MySQL.Parameter("_pagesize", MySqlDbType.Int32, 0, ParameterDirection.Input, _pagesize),
				new MySQL.Parameter("_sumfields", MySqlDbType.VarChar, 200, ParameterDirection.Input, _sumfields),
				new MySQL.Parameter("_totalcount", MySqlDbType.Int32, 0, ParameterDirection.Output, _totalcount),
				new MySQL.Parameter("_pagecount", MySqlDbType.Int32, 0, ParameterDirection.Output, _pagecount)
				);

			try
			{
				_totalcount = System.Convert.ToInt32(Outputs["_totalcount"]);
			}
			catch { }

			try
			{
				_pagecount = System.Convert.ToInt32(Outputs["_pagecount"]);
			}
			catch { }

			return CallResult;
		}

		public static int UP_GetRecordByPage(string _fields, string _tables, string _where, string _orderby, int _pageindex, int _pagesize, ref int _totalcount)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureNonQuery("UP_GetRecordByPage", ref Outputs,
				new MySQL.Parameter("_fields", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _fields),
				new MySQL.Parameter("_tables", MySqlDbType.Text, 0, ParameterDirection.Input, _tables),
				new MySQL.Parameter("_where", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _where),
				new MySQL.Parameter("_orderby", MySqlDbType.VarChar, 200, ParameterDirection.Input, _orderby),
				new MySQL.Parameter("_pageindex", MySqlDbType.Int32, 0, ParameterDirection.Input, _pageindex),
				new MySQL.Parameter("_pagesize", MySqlDbType.Int32, 0, ParameterDirection.Input, _pagesize),
				new MySQL.Parameter("_totalcount", MySqlDbType.Int32, 0, ParameterDirection.Output, _totalcount)
				);

			try
			{
				_totalcount = System.Convert.ToInt32(Outputs["_totalcount"]);
			}
			catch { }

			return CallResult;
		}

		public static int UP_GetRecordByPage(ref DataSet ds, string _fields, string _tables, string _where, string _orderby, int _pageindex, int _pagesize, ref int _totalcount)
		{
			MySQL.OutputParameter Outputs = new MySQL.OutputParameter();

			int CallResult = MySQL.ExecuteStoredProcedureWithQuery("UP_GetRecordByPage", ref ds, ref Outputs,
				new MySQL.Parameter("_fields", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _fields),
				new MySQL.Parameter("_tables", MySqlDbType.Text, 0, ParameterDirection.Input, _tables),
				new MySQL.Parameter("_where", MySqlDbType.VarChar, 2000, ParameterDirection.Input, _where),
				new MySQL.Parameter("_orderby", MySqlDbType.VarChar, 200, ParameterDirection.Input, _orderby),
				new MySQL.Parameter("_pageindex", MySqlDbType.Int32, 0, ParameterDirection.Input, _pageindex),
				new MySQL.Parameter("_pagesize", MySqlDbType.Int32, 0, ParameterDirection.Input, _pagesize),
				new MySQL.Parameter("_totalcount", MySqlDbType.Int32, 0, ParameterDirection.Output, _totalcount)
				);

			try
			{
				_totalcount = System.Convert.ToInt32(Outputs["_totalcount"]);
			}
			catch { }

			return CallResult;
		}
	}
}
