package com.starfish.muleesb.domain.productupdate;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Элемент")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class Product {
	
	private String guid;
	private String name;
	private String article;
	private String supplierArticle;
	private Double weight;
	private Double depth;
	private Double width;
	private Double height;
	private Double heelHeight;
	private String style;
	private String season;
	private String collection;
	private String productDesign;
	private String heelType;
	private String mainBox;
	private String mainImage;
	private Boolean outdated;
	private String code;
	private String codeToExchange;
	private Double shinHeight;
	private String modelGroup;
	private Double fatness;
	private String gender;
	private String type;
	private String country;
	private String brand;
	private List<String> sizes;
	private List<String> colors;
	private List<String> liningColors;
	private List<String> soleMaterials;
	private List<String> liningMaterials;
	private List<String> materials;
	private List<String> insoleMaterials;
	private List<ProductBox> productBoxes;
	private List<ProductFile> productFiles;


	@XmlElement(name = "GUID")
	public String getGuid() {
		return guid;
	}
	
	public void setGuid(String guid) {
		this.guid = guid;
	}
	
	@XmlElement(name = "Наименование")
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	@XmlElement(name = "Артикул")
	public String getArticle() {
		return article;
	}
	
	public void setArticle(String article) {
		this.article = article;
	}
	
	@XmlElement(name = "АртикулПоставщика")
	public String getSupplierArticle() {
		return supplierArticle;
	}
	
	public void setSupplierArticle(String supplierArticle) {
		this.supplierArticle = supplierArticle;
	}
	
	@XmlElement(name = "Масса")
	public Double getWeight() {
		return weight;
	}
	
	public void setWeight(Double weight) {
		this.weight = weight;
	}
	
	@XmlElement(name = "Глубина")
	public Double getDepth() {
		return depth;
	}
	
	public void setDepth(Double depth) {
		this.depth = depth;
	}
	
	@XmlElement(name = "Ширина")
	public Double getWidth() {
		return width;
	}
	
	public void setWidth(Double width) {
		this.width = width;
	}
	
	@XmlElement(name = "Высота")
	public Double getHeight() {
		return height;
	}
	
	public void setHeight(Double height) {
		this.height = height;
	}
	
	@XmlElement(name = "ВысотаКаблука")
	public Double getHeelHeight() {
		return heelHeight;
	}
	
	public void setHeelHeight(Double heelHeight) {
		this.heelHeight = heelHeight;
	}
	
	@XmlElement(name = "Стиль")
	public String getStyle() {
		return style;
	}
	
	public void setStyle(String style) {
		this.style = style;
	}
	
	@XmlElement(name = "Сезон")
	public String getSeason() {
		return season;
	}
	
	public void setSeason(String season) {
		this.season = season;
	}
	
	@XmlElement(name = "Коллекция")
	public String getCollection() {
		return collection;
	}
	
	public void setCollection(String collection) {
		this.collection = collection;
	}
	
	@XmlElement(name = "КонструкцияИзделия")
	public String getProductDesign() {
		return productDesign;
	}
	
	public void setProductDesign(String productDesign) {
		this.productDesign = productDesign;
	}
	
	@XmlElement(name = "ТипКаблука")
	public String getHeelType() {
		return heelType;
	}
	
	public void setHeelType(String heelType) {
		this.heelType = heelType;
	}
	
	@XmlElement(name = "ОсновнойКороб")
	public String getMainBox() {
		return mainBox;
	}
	
	public void setMainBox(String mainBox) {
		this.mainBox = mainBox;
	}
	
	@XmlElement(name = "ОсновноеИзображение")
	public String getMainImage() {
		return mainImage;
	}
	
	public void setMainImage(String mainImage) {
		this.mainImage = mainImage;
	}
	
	@XmlElement(name = "Устаревшее")
	public Boolean getOutdated() {
		return outdated;
	}
	
	public void setOutdated(Boolean outdated) {
		this.outdated = outdated;
	}
	
	@XmlElement(name = "Код")
	public String getCode() {
		return code;
	}
	
	public void setCode(String code) {
		this.code = code;
	}
	
	@XmlElement(name = "КодДляОбмена")
	public String getCodeToExchange() {
		return codeToExchange;
	}
	
	public void setCodeToExchange(String codeToExchange) {
		this.codeToExchange = codeToExchange;
	}
	
	@XmlElement(name = "ВысотаГоленища")
	public Double getShinHeight() {
		return shinHeight;
	}
	
	public void setShinHeight(Double shinHeight) {
		this.shinHeight = shinHeight;
	}
	
	@XmlElement(name = "МодельнаяГруппа")
	public String getModelGroup() {
		return modelGroup;
	}
	
	public void setModelGroup(String modelGroup) {
		this.modelGroup = modelGroup;
	}
	
	@XmlElement(name = "Полнота")
	public Double getFatness() {
		return fatness;
	}
	
	public void setFatness(Double fatness) {
		this.fatness = fatness;
	}
	
	@XmlElement(name = "Род")
	public String getGender() {
		return gender;
	}
	
	public void setGender(String gender) {
		this.gender = gender;
	}
	
	@XmlElement(name = "Тип")
	public String getType() {
		return type;
	}
	
	public void setType(String type) {
		this.type = type;
	}
	
	@XmlElement(name = "Страна")
	public String getCountry() {
		return country;
	}
	
	public void setCountry(String country) {
		this.country = country;
	}
	
	@XmlElement(name = "Бренд")
	public String getBrand() {
		return brand;
	}
	
	public void setBrand(String brand) {
		this.brand = brand;
	}
	
	@XmlElementWrapper(name = "Размеры")
	@XmlElement(name = "Элемент")
	public List<String> getSizes() {
		return sizes;
	}
	
	public void setSizes(List<String> sizes) {
		this.sizes = sizes;
	}
	
	@XmlElementWrapper(name = "Цвет")
	@XmlElement(name = "Элемент")
	public List<String> getColors() {
		return colors;
	}
	
	public void setColors(List<String> colors) {
		this.colors = colors;
	}
	
	@XmlElementWrapper(name = "ЦветПодкладки")
	@XmlElement(name = "Элемент")
	public List<String> getLiningColors() {
		return liningColors;
	}
	
	public void setLiningColors(List<String> liningColors) {
		this.liningColors = liningColors;
	}
	
	@XmlElementWrapper(name = "МатериалПодошвы")
	@XmlElement(name = "Элемент")
	public List<String> getSoleMaterials() {
		return soleMaterials;
	}
	
	public void setSoleMaterials(List<String> soleMaterials) {
		this.soleMaterials = soleMaterials;
	}
	
	@XmlElementWrapper(name = "МатериалПодкладки")
	@XmlElement(name = "Элемент")
	public List<String> getLiningMaterials() {
		return liningMaterials;
	}
	
	public void setLiningMaterials(List<String> liningMaterials) {
		this.liningMaterials = liningMaterials;
	}
	
	@XmlElementWrapper(name = "Материал")
	@XmlElement(name = "Элемент")
	public List<String> getMaterials() {
		return materials;
	}
	
	public void setMaterials(List<String> materials) {
		this.materials = materials;
	}
	
	@XmlElementWrapper(name = "МатериалСтельки")
	@XmlElement(name = "Элемент")
	public List<String> getInsoleMaterials() {
		return insoleMaterials;
	}
	
	public void setInsoleMaterials(List<String> insoleMaterials) {
		this.insoleMaterials = insoleMaterials;
	}
	
	@XmlElementWrapper(name = "Короба")
	@XmlElement(name = "Элемент")
	public List<ProductBox> getProductBoxes() {
		return productBoxes;
	}
	
	public void setProductBoxes(List<ProductBox> productBoxes) {
		this.productBoxes = productBoxes;
	}
	
	@XmlElementWrapper(name = "Файлы")
	@XmlElement(name = "Элемент")
	public List<ProductFile> getProductFiles() {
		return productFiles;
	}
	
	public void setProductFiles(List<ProductFile> productFiles) {
		this.productFiles = productFiles;
	}

}
