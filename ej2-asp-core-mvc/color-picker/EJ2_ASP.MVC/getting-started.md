---
layout: post
title: Getting Started with ##Platform_Name## Color Picker Component
description: Checkout and learn about getting started with ##Platform_Name## Color Picker component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

This section briefly explains about how to include a default ColorPicker in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ColorPicker to the project

We are going to render `ColorPicker` component in **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/color-picker/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/color-picker/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ColorPicker Sample](./images/color-picker.PNG)

## Run the application

After successful compilation of your application, simply press `F5` to run the application. The following example shows a default rendering of ColorPicker.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/color-picker/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/color-picker/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Inline type

By default, the ColorPicker will be rendered using SplitButton and open the pop-up to access the ColorPicker. To render the ColorPicker container alone and to access it directly, render it as inline. It can be achieved by setting the [`inline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Inline) property to `true`.

The following sample shows the inline type rendering of ColorPicker.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/color-picker/getting-started/inline/inline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/inline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/color-picker/getting-started/inline/inline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The `showButtons` property is disabled in this sample because the control buttons are not needed for inline type. To know about the control buttons functionality, refer to the [`showButtons`](./how-to/hide-control-buttons) sample.

## See Also

* [Set color value](./mode-and-value#color-value)
* [ColorPicker customization](./how-to/customize-colorpicker)