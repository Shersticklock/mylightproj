package com.starfish.muleesb.services.converters;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.starfish.muleesb.dao.DictionaryFieldDao;
import com.starfish.muleesb.domain.productupdate.Group;
import com.starfish.muleesb.domain.productupdate.Product;
import com.starfish.muleesb.domain.productupdate.ProductDictionary;

@Service
public class ProductUpdateGuidToValueConverter {
	
	@Autowired
	private DictionaryFieldDao dictionaryFieldDao;
	
	public List<Group> convert(List<Group> groups) throws SQLException {
		for (Group group : groups) {
			for (Product product : group.getProducts()) {
				if (product.getSeason() != null && !product.getSeason().equals("")) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getSeason(), "season");
					product.setSeason(extractValueFromList(values));
				}
				if (product.getCollection() != null && !product.getCollection().equals("")) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getCollection(), "collections");
					product.setCollection(extractValueFromList(values));
				}
				if (product.getProductDesign() != null && !product.getProductDesign().equals("")) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getProductDesign(), "productDesigns");
					product.setProductDesign(extractValueFromList(values));
				}
				if (product.getHeelType() != null && !product.getHeelType().equals("")) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getHeelType(), "heelTypes");
					product.setHeelType(extractValueFromList(values));
				}
				if (product.getCountry() != null && !product.getCountry().equals("")) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getCountry(), "classifierOfCountries");
					product.setCountry(extractValueFromList(values));
				}
				if (product.getColors() != null && product.getColors().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getColors(), "simpleColors");
					product.setColors(extractListFromList(values));
				}
				if (product.getLiningColors() != null && product.getLiningColors().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getLiningColors(), "simpleColors");
					product.setLiningColors(extractListFromList(values));
				}
				if (product.getSoleMaterials() != null && product.getSoleMaterials().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getSoleMaterials(), "simpleMaterials");
					product.setSoleMaterials(extractListFromList(values));
				}
				if (product.getLiningMaterials() != null && product.getLiningMaterials().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getLiningMaterials(), "simpleMaterials");
					product.setLiningMaterials(extractListFromList(values));
				}
				if (product.getMaterials() != null && product.getMaterials().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getMaterials(), "simpleMaterials");
					product.setMaterials(extractListFromList(values));
				}
				if (product.getInsoleMaterials() != null && product.getInsoleMaterials().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getInsoleMaterials(), "simpleMaterials");
					product.setInsoleMaterials(extractListFromList(values));
				}
				if (product.getSizes() != null && product.getSizes().size() > 0) {
					List<ProductDictionary> values = dictionaryFieldDao.findValue(product.getSizes(), "sizeClassifiers");
					product.setSizes(extractListFromList(values));
				}
			}
		}
		return groups;
	}
	
	private String extractValueFromList(List<ProductDictionary> list) {
		if (list == null || list.isEmpty()) {
			return null;
		}
		boolean needComma = false;
		StringBuilder result = new StringBuilder("");
		for (ProductDictionary item : list) {
			if (needComma) {
				result.append(",");
			}
			result.append(item.getValue());
			needComma = true;
		}
		return result.toString();
	}
	
	private List<String> extractListFromList(List<ProductDictionary> list) {
		if (list == null || list.isEmpty()) {
			return null;
		}
		List<String> result = new ArrayList<String>();
		for (ProductDictionary item : list) {
			result.add(item.getValue());
		}
		return result;
	}

}
