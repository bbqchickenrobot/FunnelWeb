﻿/// <reference path="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.4.4-vsdoc.js" />
/// <reference path="../JQuery/jquery.tmpl.js" />

(function () {

    jQuery.fn.taggy = function (options) {
        var that = this;
        var defaults = {
            url: '/tag/'
        };

        var template = '<p data-id="${Id}">${Name}</p>';

        var tagCache = {};

        var opts = jQuery.extend(true, options, defaults);

        var load = function () {
            if (tagCache.hasOwnProperty(that.val())) {
                displayData();
            } else {
                jQuery.getJSON(opts.url + that.val(), null, function (result) {
                    tagCache[that.val()] = result;

                    displayData();
                });
            }
        };

        var displayData = function () {
            $.template('tags', template);

            var html = $.tmpl('tags', tagCache[that.val()]);

            var bubble = $('<p class="triangle-border top"></p>').html(html);

            console.log(bubble);

            bubble.insertBefore(that);
        };

        that.keyup(function (e) {
            switch (e.which) {
                case 188:
                    //new tag
                    break;
                case 8:
                    if (that.val() !== '') {
                        load();
                    }
                    break;
                default:
                    load();
                    break;
            }
        });
    };
})();

jQuery('.taggy').taggy();