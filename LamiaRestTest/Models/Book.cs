using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LamiaRestTest.Models
{
    public class Language
    {
        public string key { get; set; }

    }

    public class Type
    {
        public string key { get; set; }

    }

    public class LastModified
    {
        public string type { get; set; }
        public DateTime value { get; set; }

    }

    public class Author
    {
        public string name { get; set; }
        public string key { get; set; }

    }

    public class Created
    {
        public string type { get; set; }
        public DateTime value { get; set; }

    }

    public class Identifiers
    {
        public List<string> librarything { get; set; }
        public List<string> wikidata { get; set; }
        public List<string> goodreads { get; set; }

    }

    public class Work
    {
        public string key { get; set; }

    }

    public class Details2
    {
        public List<int> covers { get; set; }
        public List<string> local_id { get; set; }
        public List<string> lc_classifications { get; set; }
        public int latest_revision { get; set; }
        public List<string> source_records { get; set; }
        public string title { get; set; }
        public List<Language> languages { get; set; }
        public List<string> subjects { get; set; }
        public string publish_country { get; set; }
        public string by_statement { get; set; }
        public List<string> oclc_numbers { get; set; }
        public Type type { get; set; }
        public int revision { get; set; }
        public List<string> publishers { get; set; }
        public LastModified last_modified { get; set; }
        public string key { get; set; }
        public List<Author> authors { get; set; }
        public List<string> publish_places { get; set; }
        public string pagination { get; set; }
        public Created created { get; set; }
        public List<string> dewey_decimal_class { get; set; }
        public Identifiers identifiers { get; set; }
        public List<string> lccn { get; set; }
        public List<string> isbn_10 { get; set; }
        public string publish_date { get; set; }
        public List<Work> works { get; set; }

    }

    public class Details
    {
        public string info_url { get; set; }
        public string bib_key { get; set; }
        public string preview_url { get; set; }
        public string thumbnail_url { get; set; }
        public Details2 details { get; set; }
        public string preview { get; set; }

    }

    public class Publisher
    {
        public string name { get; set; }

    }

    public class Classifications
    {
        public List<string> dewey_decimal_class { get; set; }
        public List<string> lc_classifications { get; set; }

    }

    public class Identifiers2
    {
        public List<string> lccn { get; set; }
        public List<string> openlibrary { get; set; }
        public List<string> isbn_10 { get; set; }
        public List<string> wikidata { get; set; }
        public List<string> oclc { get; set; }
        public List<string> goodreads { get; set; }
        public List<string> librarything { get; set; }

    }

    public class Cover
    {
        public string small { get; set; }
        public string large { get; set; }
        public string medium { get; set; }

    }

    public class Subject
    {
        public string url { get; set; }
        public string name { get; set; }

    }

    public class Author2
    {
        public string url { get; set; }
        public string name { get; set; }

    }

    public class PublishPlace
    {
        public string name { get; set; }

    }

    public class Data
    {
        public List<Publisher> publishers { get; set; }
        public string pagination { get; set; }
        public Classifications classifications { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public Identifiers2 identifiers { get; set; }
        public Cover cover { get; set; }
        public List<Subject> subjects { get; set; }
        public string publish_date { get; set; }
        public string key { get; set; }
        public List<Author2> authors { get; set; }
        public string by_statement { get; set; }
        public List<PublishPlace> publish_places { get; set; }

    }

    public class BookDetails
    {
        public string recordURL { get; set; }
        public List<string> oclcs { get; set; }
        public List<string> publishDates { get; set; }
        public List<string> lccns { get; set; }
        public Details details { get; set; }
        public List<string> isbns { get; set; }
        public List<string> olids { get; set; }
        public List<object> issns { get; set; }
        public Data data { get; set; }

    }

    public class Records : Dictionary<string, BookDetails>
    {
    }


    public class Book
{
    public Records records { get; set; }
    public List<object> items { get; set; }
}


}
