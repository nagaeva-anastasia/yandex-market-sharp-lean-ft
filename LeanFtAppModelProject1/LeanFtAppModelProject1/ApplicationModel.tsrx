<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>ApplicationModel</className>
  <objects>
    <object technology="Web" type="Page">
      <name>SearchResultPage</name>
      <codeName>SearchResultPage</codeName>
      <identification />
      <children>
        <object technology="Web" type="EditField">
          <name>priceFrom</name>
          <codeName>PriceFromEditField</codeName>
          <identification>
            <properties>
              <property name="TagName" type="string">INPUT</property>
              <property name="XPath" type="string">//INPUT[@id="gf-pricefrom-var"]</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>priceTo</name>
          <codeName>PriceToEditField</codeName>
          <identification>
            <properties>
              <property name="XPath" type="string">//INPUT[@id="gf-priceto-var"]</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="WebElement">
          <name>productCards</name>
          <codeName>ProductCardsWebElement</codeName>
          <identification>
            <properties>
              <property name="XPath" type="string">//div[contains(@class,'snippet-card__info')]</property>
            </properties>
            <index>0</index>
          </identification>
        </object>
        <object technology="Web" type="WebElement">
          <name>checkedsValuesContainer</name>
          <codeName>CheckedsValuesContainer</codeName>
          <identification>
            <properties>
              <property name="IsVisible" type="boolean">true</property>
              <property name="XPath" type="string">//div[contains(@class,'filter-block__list')]</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
    <object technology="Web" type="Page">
      <name>MobilePhonesPage</name>
      <codeName>MobilePhonesPage</codeName>
      <identification />
      <children>
        <object technology="Web" type="WebElement">
          <name>mobilePhoneHeader</name>
          <codeName>MobilePhoneHeaderWebElement</codeName>
          <identification>
            <properties>
              <property name="ClassName" type="string">b-page-title__title</property>
              <property name="TagName" type="string">H1</property>
              <property name="InnerText" type="string">Мобильные телефоны</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Button">
          <name>setFiltersButton</name>
          <codeName>SetFiltersButton</codeName>
          <identification>
            <properties>
              <property name="ButtonType" type="string">submit</property>
              <property name="Text" type="string">Подобрать</property>
              <property name="TagName" type="string">INPUT</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="ListBox">
          <name>typeSelect</name>
          <codeName>TypeSelectListBox</codeName>
          <identification>
            <properties>
              <property name="TagName" type="string">SELECT</property>
              <property name="Name" type="string">2142542726</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="ListBox">
          <name>platformSelect</name>
          <codeName>PlatformSelectListBox</codeName>
          <identification>
            <properties>
              <property name="TagName" type="string">SELECT</property>
              <property name="Name" type="string">2142557977</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>priceTo</name>
          <codeName>PriceToEditField</codeName>
          <identification>
            <properties>
              <property name="TagName" type="string">INPUT</property>
              <property name="Name" type="string">2140131887</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="EditField">
          <name>priceFrom</name>
          <codeName>PriceFromEditField</codeName>
          <identification>
            <properties>
              <property name="TagName" type="string">INPUT</property>
              <property name="Name" type="string">2140131888</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
    <object technology="Web" type="Page">
      <name>MainPage</name>
      <codeName>MainPage</codeName>
      <identification>
        <properties>
          <property name="Url" type="string">https://market.yandex.ru</property>
        </properties>
      </identification>
      <children>
        <object technology="Web" type="Image">
          <name>YandexLogo</name>
          <codeName>YandexLogoImage</codeName>
          <identification>
            <properties>
              <property name="Href" type="string">http://www.yandex.ru/</property>
              <property name="Type" type="enum">Link</property>
              <property name="TagName" type="string">IMG</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Link">
          <name>electronikLink</name>
          <codeName>ElectronikLink</codeName>
          <identification>
            <properties>
              <property name="ClassName" type="string">link topmenu__link</property>
              <property name="InnerText" type="string">Электроника</property>
              <property name="IsVisible" type="boolean">true</property>
              <property name="XPath" type="string">//LI[1]/A[1]</property>
            </properties>
          </identification>
        </object>
        <object technology="Web" type="Link">
          <name>mobilePhoneLink</name>
          <codeName>MobilePhoneLink</codeName>
          <identification>
            <properties>
              <property name="InnerText" type="string">Мобильные телефоны</property>
            </properties>
            <index>0</index>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>