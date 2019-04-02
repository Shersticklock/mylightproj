package com.starfish.muleesb.services.converters;

import java.util.ArrayList;
import java.util.List;

import com.starfish.muleesb.domain.productupdate.CustomAttribute;
import com.starfish.muleesb.domain.productupdate.Product;
import com.starfish.muleesb.domain.productupdate.ProductJson;

public class ProductForUpdateToJsonConverter {

	public List<ProductJson> convert(List<Product> products) {
		List<ProductJson> result = new ArrayList<ProductJson>();
		
		for (Product product : products) {
			ProductJson productJson = new ProductJson();
			productJson.setCustomAttributes(new ArrayList<CustomAttribute>());
			
			if (product.getName() != null && !product.getName().equals("")) {
				productJson.setName(product.getName());
			}
			
			if (product.getArticle() != null && !product.getArticle().equals("")) {
				productJson.setArticle(product.getArticle());
			}
			
			if (product.getCodeToExchange() != null && !product.getCodeToExchange().equals("")) {
				String codeToExchange = product.getCodeToExchange();
				productJson.setId(codeToExchange);
				productJson.setProductUrl("https://www.mascotte.ru/obuv_id" + codeToExchange);
				productJson.setImageUrl("https://www.mascotte.ru/images/products/" + codeToExchange.substring(0, 3) +
						"/" + codeToExchange + "/" + codeToExchange + "_thm.jpg");
			}
			
			if (product.getSeason() != null && !product.getSeason().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("season");
				attr.setValue(product.getSeason());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getCollection() != null && !product.getCollection().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("collection");
				attr.setValue(product.getCollection());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getProductDesign() != null && !product.getProductDesign().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("construction");
				attr.setValue(product.getProductDesign());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getHeelType() != null && !product.getHeelType().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("heeltype");
				attr.setValue(product.getHeelType());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getGender() != null && !product.getGender().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("gender");
				attr.setValue(product.getGender());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getCountry() != null && !product.getCountry().equals("")) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("countryOfOrigin");
				attr.setValue(product.getCountry());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getColors() != null && product.getColors().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("color");
				attr.setValue(extractFromList(product.getColors()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getLiningColors() != null && product.getLiningColors().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("liningColor");
				attr.setValue(extractFromList(product.getLiningColors()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getSoleMaterials() != null && product.getSoleMaterials().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("soleMaterial");
				attr.setValue(extractFromList(product.getSoleMaterials()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getLiningMaterials() != null && product.getLiningMaterials().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("liningMaterial");
				attr.setValue(extractFromList(product.getLiningMaterials()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getMaterials() != null && product.getMaterials().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("material");
				attr.setValue(extractFromList(product.getMaterials()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getInsoleMaterials() != null && product.getInsoleMaterials().size() > 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("insoleMaterial");
				attr.setValue(extractFromList(product.getInsoleMaterials()));
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getWeight() != null && product.getWeight() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("weight");
				attr.setValue(product.getWeight().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getDepth() != null && product.getDepth() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("depth");
				attr.setValue(product.getDepth().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getWidth() != null && product.getWidth() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("width");
				attr.setValue(product.getWidth().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getHeight() != null && product.getHeight() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("height");
				attr.setValue(product.getHeight().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getHeelHeight() != null && product.getHeelHeight() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("heelHeight");
				attr.setValue(product.getHeelHeight().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (product.getShinHeight() != null && product.getShinHeight() != 0) {
				CustomAttribute attr = new CustomAttribute();
				attr.setName("bootlegHeight");
				attr.setValue(product.getShinHeight().toString());
				productJson.getCustomAttributes().add(attr);
			}
			
			if (productJson.getCustomAttributes().size() <= 0) {
				productJson.setCustomAttributes(null);
			}
			
			result.add(productJson);
			
			if (product.getSizes() != null) {
				for (String size : product.getSizes()) {
					String sizeForId = size;
					int separatorIndex = getIndexOfSizeSeparator(size);
					if (separatorIndex != -1) {
						sizeForId = size.substring(0, separatorIndex);
					}
					ProductJson daughterProduct = new ProductJson();
					daughterProduct.setParentId(productJson.getId());
					daughterProduct.setId(productJson.getId() + "_" + sizeForId);
					daughterProduct.setName("Размер " + size);
					result.add(daughterProduct);
				}
			}
		}
		
		return result;
	}
	
	private String extractFromList(List<String> list) {
		boolean needComma = false;
		StringBuilder result = new StringBuilder();
		for (String str : list) {
			if (needComma) {
				result.append(",");
			}
			result.append(str);
			needComma = true;
		}
		return result.toString();
	}
	
	private int getIndexOfSizeSeparator(String size) {
		int index = -1;
		
		int dashIndex = size.indexOf("-");
		int commaIndex = size.indexOf(",");
		int dotIndex = size.indexOf(".");
		
		if (dashIndex == -1) dashIndex = 5000;
		if (commaIndex == -1) commaIndex = 5000;
		if (dotIndex == -1) dotIndex = 5000;
		
		index = Math.min(dashIndex, commaIndex);
		index = Math.min(index, dotIndex);
		
		if (index == 5000) return -1;
		return index;
	}

}
