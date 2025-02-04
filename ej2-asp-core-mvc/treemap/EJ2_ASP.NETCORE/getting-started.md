---
layout: post
title: Getting Started with ##Platform_Name## Treemap Component
description: Checkout and learn about getting started with ##Platform_Name## Treemap component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core

This section explains you the steps required to create a TreeMap and demonstrate the basic usage of the TreeMap control.

## Prerequisites

To get start with ASP.NET Core application, need to ensure the following software to be installed on the machine.

* Visual Studio 2017
* DotNet Core 2.0

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The following steps to create ASP.NET Core Application.

**Step 1:** Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using Nugget Package Manager.

Open the `nuGet` package manager.

![Alt text](./images/solution-Explorer.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml.**

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

**Step 5:** Adding Script Manager in layout page **_Layout.cshtml.**

```cs
<ejs-scripts></ejs-scripts>
```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the smith chart.

```html

@using Syncfusion.EJ2;
 <ejs-treemap id="treemap">
</ejs-treemap>

```

## Render tree map

This section explains how to render the tree map with data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-source.cs" %}
{% include code-snippet/treemap/getting-started/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/data-source/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-source.cs" %}
{% include code-snippet/treemap/getting-started/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Here, the tree map is created with data source and set with the [`weightValuePath`] as count. You can customize the leaf level tree map items using the [`leafItemSettings`]. The properties such as [`fill`], [`border`], and [`labelPosition`] can be changed using the [`leafItemSettings`].

## Apply color mapping

The color mapping feature supports customization of item colors based on the underlying value of item received from bound data source. Specify the field name from the values that have to be compared for the item in the [`equalColorValuePath`] or [`rangeColorValuePath`] property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/color-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color-mapping.cs" %}
{% include code-snippet/treemap/getting-started/color-mapping/color-mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/color-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color-mapping.cs" %}
{% include code-snippet/treemap/getting-started/color-mapping/color-mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable legend

You can show legend for the tree map by setting the [`visible`] property to true in [`legendSettings`] object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/treemap/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/treemap/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add labels

The labels are added to show additional information of the items in tree map. By default, the visibility of the label is true. This can be customized using the [`showLabels`] property in [`leafItemSettings`].

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labels.cs" %}
{% include code-snippet/treemap/getting-started/labels/labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labels.cs" %}
{% include code-snippet/treemap/getting-started/labels/labels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable tooltip

The tooltips are used when labels cannot display information due to space constraints. Tooltips can be enabled by setting the [`visible`] property to true in [`tooltipSettings`] object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/treemap/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/getting-started/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/treemap/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

