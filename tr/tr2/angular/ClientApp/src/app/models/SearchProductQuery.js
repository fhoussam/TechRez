"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var ISearchQueryExtension_1 = require("./ISearchQueryExtension");
var SearchProductQuery = /** @class */ (function (_super) {
    __extends(SearchProductQuery, _super);
    function SearchProductQuery() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return SearchProductQuery;
}(ISearchQueryExtension_1.SearchQueryExtension));
exports.SearchProductQuery = SearchProductQuery;
//# sourceMappingURL=SearchProductQuery.js.map