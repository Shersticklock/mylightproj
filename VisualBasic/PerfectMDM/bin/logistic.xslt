<?xml version="1.0" encoding="windows-1251"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ymaps="http://maps.yandex.ru/ymaps/1.x" xmlns:gml="http://www.opengis.net/gml" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:georss="http://www.georss.org/georss" xmlns:atom="http://www.w3.org/2005/Atom" version="1.0">

  <xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>

  <xsl:template match="/">
    <ymaps:ymaps>
      <ymaps:GeoObjectCollection>
        <gml:featureMembers>
          <ymaps:GeoObjectCollection>
            <gml:name>Наша компания</gml:name>
            <gml:featureMembers>
              <ymaps:GeoObject>
                <gml:name>Экспресс-Реклама</gml:name>
                <gml:description>3</gml:description>
                <gml:Point>
                  <gml:pos>30.335748 59.887609</gml:pos>
                </gml:Point>
              </ymaps:GeoObject>
            </gml:featureMembers>
            <ymaps:style>default#orangePoint</ymaps:style>
          </ymaps:GeoObjectCollection>
          <ymaps:GeoObjectCollection>
            <gml:name>Все заявки на доставку</gml:name>
            <gml:featureMembers>
              <xsl:for-each select = "//item/dateDiff">
                <xsl:call-template name="item"></xsl:call-template>
              </xsl:for-each>
            </gml:featureMembers>
            <ymaps:style>default#greenPoint</ymaps:style>
          </ymaps:GeoObjectCollection>
          <ymaps:GeoObjectCollection>
            <gml:name>Заявки на сегодняу</gml:name>
            <gml:featureMembers>
              <xsl:for-each select = "//item/dateDiff[text()=0]">
                <xsl:call-template name="item"></xsl:call-template>
              </xsl:for-each>
            </gml:featureMembers>
            <ymaps:style>default#magentaPoint</ymaps:style>
          </ymaps:GeoObjectCollection>
          <ymaps:GeoObjectCollection>
            <gml:name>Заявки на завтрау</gml:name>
            <gml:featureMembers>
              <xsl:for-each select = "//item/dateDiff[text()=-1]">
                <xsl:call-template name="item"></xsl:call-template>
              </xsl:for-each>
            </gml:featureMembers>
            <ymaps:style>default#violetPoint</ymaps:style>
          </ymaps:GeoObjectCollection>
        </gml:featureMembers>
      </ymaps:GeoObjectCollection>
    </ymaps:ymaps>
  </xsl:template>

  <xsl:template name="item">
    <ymaps:GeoObject>
      <gml:name>
        <xsl:value-of select="../name"/>
      </gml:name>
      <gml:description>
        <xsl:apply-templates select="../address"/>
      </gml:description>
      <gml:Point>
        <gml:pos>
          <xsl:apply-templates select="../pos"/>
        </gml:pos>
      </gml:Point>
    </ymaps:GeoObject>
  </xsl:template>

  <xsl:template match="georss:point">
    <xsl:value-of select="substring-after(.,' ')"/>
    <xsl:text> </xsl:text>
    <xsl:value-of select="substring-before(.,' ')"/>
  </xsl:template>

</xsl:stylesheet>
