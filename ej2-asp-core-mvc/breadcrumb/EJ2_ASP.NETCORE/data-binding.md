---
layout: post
title: Data Binding in ##Platform_Name## Breadcrumb Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Breadcrumb component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding in Breadcrumb

## Items as tag directive

The Breadcrumb contains `e-breadcrumb-items` and `e-breadcrumb-item` tags to render items for the component. To bind items, use `e-breadcrumb-items` tag and `e-breadcrumb-item` tag to bind properties for breadcrumb items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


![Breadcrumb Sample](./images/items.PNG)

## Items based on current Url

The Breadcrumb items can be generated from the current URL of the page, if the `url` property is not provided or when the user does not specify the breadcrumb items using the BreadcrumbItemDirective tag.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/current-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Current-url.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/current-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Current-url.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


![Breadcrumb Sample](./images/breadcrumb-current-url.PNG)

> This output screenshot shows the [Bind to Location](https://ej2.syncfusion.com/aspnetcore/Breadcrumb/BindToLocation#/bootstrap5) sample.
> This sample is hosted in different location, so the breadcrumb is rendered with different location instead of the actual location.

### Static URL

The Breadcrumb items can be generated by providing the `url` property in the component, if the user does not specify the breadcrumb items using the BreadcrumbItemDirective tag.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/navigation/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/navigation/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Breadcrumb Sample](./images/static.PNG)

## Customize text when generated items using Url

The Breadcrumb items text can be customized by using the `beforeItemRender` event. In the following example, `All Components` text was customized as `Components`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/data-binding/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/data-binding/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Breadcrumb Sample](./images/data-binding.PNG)