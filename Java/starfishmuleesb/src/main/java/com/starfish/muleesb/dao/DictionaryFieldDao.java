package com.starfish.muleesb.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;
import java.util.UUID;

import javax.sql.DataSource;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import com.starfish.muleesb.domain.productupdate.ProductDictionary;

@Repository
public class DictionaryFieldDao {
	
	private JdbcTemplate jdbcTemplate;

	@Autowired
	public void setDataSource(DataSource dataSource) {
		this.jdbcTemplate = new JdbcTemplate(dataSource);
	}

	public List<ProductDictionary> findValue(final String guid, final String type) {
		String sql = "SELECT df.name AS name, df.value AS value FROM dictionary d INNER JOIN dictionaryfields df ON df.dictionaryid=d.id WHERE d.guid=? AND d.type=?;";
		UUID uuid = UUID.fromString(guid);
		return jdbcTemplate.query(sql, new Object[] {uuid, type}, new RowMapper<ProductDictionary>() {
			@Override
			public ProductDictionary mapRow(ResultSet rs, int rowNum) throws SQLException {
				ProductDictionary item = new ProductDictionary();
				item.setGuid(guid);
				item.setType(type);
				item.setName(rs.getString("name"));
				item.setValue(rs.getString("value"));
				return item;
			}
		});
	}

	public List<ProductDictionary> findValue(List<String> guidList, final String type) {
		StringBuilder guids = new StringBuilder();
		boolean needOrWord = false;
		for (String guid : guidList) {
			if (needOrWord) {
				guids.append(" OR ");
			}
			guids.append("d.guid='").append(guid).append("'");
			needOrWord = true;
		}

		String sql = "SELECT d.guid AS guid, df.name AS name, df.value AS value FROM dictionary d INNER JOIN dictionaryfields df ON df.dictionaryid=d.id WHERE ("
				+ guids.toString() + ") AND d.type=?;";
		return jdbcTemplate.query(sql, new Object[] {type}, new RowMapper<ProductDictionary>() {
			@Override
			public ProductDictionary mapRow(ResultSet rs, int rowNum) throws SQLException {
				ProductDictionary item = new ProductDictionary();
				 item.setGuid(rs.getString("guid"));
				 item.setType(type);
				 item.setName(rs.getString("name"));
				 item.setValue(rs.getString("value"));
				return item;
			}
		});
	}

}
