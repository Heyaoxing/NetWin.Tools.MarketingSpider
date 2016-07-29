/*
Navicat MySQL Data Transfer

Source Server         : 10.0.2.31
Source Server Version : 50616
Source Host           : 10.0.2.31:3306
Source Database       : test_shove_netwin

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2016-07-29 15:39:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_synth_release_site
-- ----------------------------
DROP TABLE IF EXISTS `t_synth_release_site`;
CREATE TABLE `t_synth_release_site` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `site_id` bigint(20) DEFAULT NULL,
  `trade_id` bigint(20) DEFAULT NULL COMMENT '行业ID',
  `release_name` varchar(255) DEFAULT NULL,
  `user_site_url` varchar(255) DEFAULT NULL COMMENT '营销站点网址',
  `user_site_name` varchar(255) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL COMMENT '创建时间',
  `pass_time` datetime DEFAULT NULL COMMENT '通过时间',
  `stop_time` datetime DEFAULT NULL COMMENT '停止时间',
  `update_time` timestamp NULL DEFAULT NULL COMMENT '修改时间',
  `is_temporary` bit(1) DEFAULT b'0' COMMENT '是否临时数据',
  `state` smallint(6) DEFAULT '0' COMMENT '状态 0审核 1投放 2暂停 3创建中',
  `long_quantity` bigint(20) DEFAULT '0' COMMENT '长关键词数量 ',
  `user_id` bigint(20) DEFAULT NULL,
  `is_acquiesce` bit(1) DEFAULT b'0' COMMENT '是否设为默认 1 ',
  `cause` varchar(255) DEFAULT NULL COMMENT '驳回原因',
  `is_eims_url` bit(1) DEFAULT b'0' COMMENT '是否移动云网站。0：不是；1：是',
  `eims_site_id` bigint(20) DEFAULT '-1' COMMENT '移动云网站站点编号',
  `is_erased` bit(1) DEFAULT b'0',
  `restart_time` datetime DEFAULT NULL COMMENT '重启时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=853 DEFAULT CHARSET=utf8 COMMENT=' (广告计划基本信息表)';








/*
Navicat MySQL Data Transfer

Source Server         : 10.0.2.31
Source Server Version : 50616
Source Host           : 10.0.2.31:3306
Source Database       : test_shove_netwin

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2016-07-29 15:39:10
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_synth_release_sitemap
-- ----------------------------
DROP TABLE IF EXISTS `t_synth_release_sitemap`;
CREATE TABLE `t_synth_release_sitemap` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `create_time` datetime NOT NULL,
  `release_site_id` bigint(20) NOT NULL COMMENT '对应表t_synth_release_site的id',
  `title` varchar(255) DEFAULT NULL COMMENT '网页title',
  `url` varchar(255) DEFAULT NULL COMMENT '网页链接',
  PRIMARY KEY (`id`),
  KEY `release_site_id_1` (`release_site_id`) USING BTREE,
  KEY `title_1` (`title`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=10605 DEFAULT CHARSET=utf8 COMMENT='广告计划推广的站点的站点地图表';

