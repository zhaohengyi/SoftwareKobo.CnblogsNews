﻿using GalaSoft.MvvmLight;
using System;
using SoftwareKobo.CnblogsNews.Service;

namespace SoftwareKobo.CnblogsNews.Model
{
    public class News : ObservableObject
    {
        private int _commentCount;

        private string _publishTime;

        private string _title;

        public int CommentCount
        {
            get
            {
                return _commentCount;
            }
            set
            {
                _commentCount = value;
                RaisePropertyChanged(() => CommentCount);
            }
        }

        public Uri DetailLink
        {
            get
            {
                return new Uri(new Uri(NewsService.NewsBaseUrl, UriKind.Absolute), string.Format("/m/n/{0}", this.NewsId));
            }
        }

        public Uri CommentLink
        {
            get
            {
                return new Uri(new Uri(NewsService.NewsBaseUrl, UriKind.Absolute), string.Format("/mc?id={0}", this.NewsId));
            }
        }

        public string NewsId
        {
            get;
            set;
        }

        public string PublishTime
        {
            get
            {
                return _publishTime;
            }
            set
            {
                _publishTime = value;
                RaisePropertyChanged(() => PublishTime);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }
    }
}