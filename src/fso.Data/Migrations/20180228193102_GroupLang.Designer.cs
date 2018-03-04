﻿// <auto-generated />
using fso.Core.Domains;
using fso.Core.Domains.Helpers.Enum;
using fso.Core.Domains.MMEntities;
using fso.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace fso.Data.Migrations
{
    [DbContext(typeof(FsoContext))]
    [Migration("20180228193102_GroupLang")]
    partial class GroupLang
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("fso.Core.Domains.AppMediaFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlurLazyPath")
                        .HasMaxLength(1024);

                    b.Property<int?>("CoverGroupId");

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<string>("FileExtension")
                        .HasMaxLength(16);

                    b.Property<string>("ImageDimension")
                        .HasMaxLength(16);

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<string>("Path")
                        .HasMaxLength(1024);

                    b.Property<int?>("PostCollectionId");

                    b.Property<int?>("PostPartId");

                    b.Property<int?>("ProfileGroupId");

                    b.Property<string>("ResizedPath")
                        .HasMaxLength(1024);

                    b.Property<string>("SmallPath")
                        .HasMaxLength(1024);

                    b.Property<string>("ThumbPath")
                        .HasMaxLength(1024);

                    b.Property<string>("UserInfoId");

                    b.HasKey("Id");

                    b.HasIndex("CoverGroupId")
                        .IsUnique()
                        .HasFilter("[CoverGroupId] IS NOT NULL");

                    b.HasIndex("PostCollectionId")
                        .IsUnique()
                        .HasFilter("[PostCollectionId] IS NOT NULL");

                    b.HasIndex("PostPartId")
                        .IsUnique()
                        .HasFilter("[PostPartId] IS NOT NULL");

                    b.HasIndex("ProfileGroupId")
                        .IsUnique()
                        .HasFilter("[ProfileGroupId] IS NOT NULL");

                    b.HasIndex("UserInfoId")
                        .IsUnique()
                        .HasFilter("[UserInfoId] IS NOT NULL");

                    b.ToTable("AppMediaFile");
                });

            modelBuilder.Entity("fso.Core.Domains.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("Content")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int?>("ParentCommentId");

                    b.Property<int?>("ReviewId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("fso.Core.Domains.CommentUser", b =>
                {
                    b.Property<int?>("CommentId");

                    b.Property<string>("UserInfoId");

                    b.Property<int>("LikeStatus");

                    b.HasKey("CommentId", "UserInfoId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("CommentUser");
                });

            modelBuilder.Entity("fso.Core.Domains.FollowInfo", b =>
                {
                    b.Property<string>("FollowedId");

                    b.Property<string>("FollowerId");

                    b.Property<DateTime>("DateUtcFollowed");

                    b.Property<int>("FollowState");

                    b.HasKey("FollowedId", "FollowerId");

                    b.HasIndex("FollowerId");

                    b.ToTable("FollowInfo");
                });

            modelBuilder.Entity("fso.Core.Domains.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About")
                        .HasMaxLength(1024);

                    b.Property<string>("ColorAlpha")
                        .HasMaxLength(256);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("UrlKey")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasAlternateKey("UrlKey");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.GroupPost", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("PostId");

                    b.Property<DateTime>("DateUtcAdded");

                    b.Property<int?>("PostPopularityLevel");

                    b.HasKey("GroupId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("GroupPost");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.GroupRelation", b =>
                {
                    b.Property<int>("ParentGroupId");

                    b.Property<int>("ChildGroupId");

                    b.Property<int?>("DominateValue");

                    b.HasKey("ParentGroupId", "ChildGroupId");

                    b.HasIndex("ChildGroupId");

                    b.ToTable("GroupRelation");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserGroup", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("DateUtcFollowed");

                    b.Property<int>("GroupFollowState");

                    b.Property<string>("LanguageOfUser");

                    b.Property<int>("UserReputationInGroup");

                    b.HasKey("GroupId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserPostLike", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<string>("UserInfoId");

                    b.Property<DateTime>("DateUtcLiked");

                    b.HasKey("PostId", "UserInfoId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("UserPostLike");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserReview", b =>
                {
                    b.Property<int>("ReviewId");

                    b.Property<string>("UserInfoId");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<int>("LikeStatus");

                    b.HasKey("ReviewId", "UserInfoId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("UserReview");
                });

            modelBuilder.Entity("fso.Core.Domains.Popularity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CultureCode");

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<DateTime>("OnTrendingEndUtcTime");

                    b.Property<DateTime>("OnTrendingStartUtcTime");

                    b.Property<int>("PopularityLevel");

                    b.Property<int?>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("PostId");

                    b.ToTable("Popularity");
                });

            modelBuilder.Entity("fso.Core.Domains.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CollectionId");

                    b.Property<string>("Content")
                        .HasMaxLength(5012);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<DateTime>("DateUtcPublished");

                    b.Property<string>("Description")
                        .HasMaxLength(2048);

                    b.Property<bool>("IsPublished");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int>("PrivacyStatus");

                    b.Property<double?>("Rating");

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.Property<string>("UserInfoId");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("fso.Core.Domains.PostCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<string>("Description")
                        .HasMaxLength(320);

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("PrivacyStatus");

                    b.Property<int?>("ThumbFileId");

                    b.Property<string>("UserInfoId");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("PostCollection");
                });

            modelBuilder.Entity("fso.Core.Domains.PostPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<string>("Description");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int?>("PostId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostPart");
                });

            modelBuilder.Entity("fso.Core.Domains.ReputationGain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<double>("GainedReputationValue");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int?>("PostId");

                    b.Property<int?>("ReviewId");

                    b.Property<string>("UserInfoId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("ReviewId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("ReputationGain");
                });

            modelBuilder.Entity("fso.Core.Domains.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(10126);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<DateTime>("DateUtcPublished");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int?>("PostId");

                    b.Property<double?>("PostRate");

                    b.Property<string>("UserId");

                    b.Property<double?>("UserReputation");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("fso.Core.Domains.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId")
                        .HasMaxLength(64);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<int>("FeedType");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<int?>("ParentEntityId");

                    b.Property<int>("ParentEntityType");

                    b.Property<int?>("SourceEntityId");

                    b.HasKey("Id");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("fso.Core.Domains.UserInfo", b =>
                {
                    b.Property<string>("AppUserId")
                        .HasMaxLength(64);

                    b.Property<string>("AlphaColor")
                        .HasMaxLength(32);

                    b.Property<DateTime>("DateUtcAdd");

                    b.Property<DateTime>("DateUtcModified");

                    b.Property<int>("FollowSetting");

                    b.Property<int>("Id");

                    b.Property<bool>("IsSoftDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<int>("PrivacySetting");

                    b.Property<int?>("ProfilePictureId");

                    b.Property<string>("Status")
                        .HasMaxLength(512);

                    b.Property<string>("Surname")
                        .HasMaxLength(128);

                    b.Property<string>("UName")
                        .HasMaxLength(64);

                    b.HasKey("AppUserId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("fso.Core.Domains.AppMediaFile", b =>
                {
                    b.HasOne("fso.Core.Domains.Group", "CoverGroup")
                        .WithOne("CoverImage")
                        .HasForeignKey("fso.Core.Domains.AppMediaFile", "CoverGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("fso.Core.Domains.PostCollection", "PostCollection")
                        .WithOne("ThumbFile")
                        .HasForeignKey("fso.Core.Domains.AppMediaFile", "PostCollectionId");

                    b.HasOne("fso.Core.Domains.PostPart", "PostPart")
                        .WithOne("Image")
                        .HasForeignKey("fso.Core.Domains.AppMediaFile", "PostPartId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("fso.Core.Domains.Group", "ProfileGroup")
                        .WithOne("ProfileImage")
                        .HasForeignKey("fso.Core.Domains.AppMediaFile", "ProfileGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithOne("ProfilePicture")
                        .HasForeignKey("fso.Core.Domains.AppMediaFile", "UserInfoId");
                });

            modelBuilder.Entity("fso.Core.Domains.Comment", b =>
                {
                    b.HasOne("fso.Core.Domains.UserInfo", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("fso.Core.Domains.Review", "Review")
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("fso.Core.Domains.CommentUser", b =>
                {
                    b.HasOne("fso.Core.Domains.Comment", "Comment")
                        .WithMany("CommentLikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("CommentLikes")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fso.Core.Domains.FollowInfo", b =>
                {
                    b.HasOne("fso.Core.Domains.UserInfo", "Follower")
                        .WithMany("Followers")
                        .HasForeignKey("FollowedId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("fso.Core.Domains.UserInfo", "Followed")
                        .WithMany("Following")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.GroupPost", b =>
                {
                    b.HasOne("fso.Core.Domains.Group", "Group")
                        .WithMany("Posts")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("fso.Core.Domains.Post", "Post")
                        .WithMany("Groups")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.GroupRelation", b =>
                {
                    b.HasOne("fso.Core.Domains.Group", "Child")
                        .WithMany("Childs")
                        .HasForeignKey("ChildGroupId");

                    b.HasOne("fso.Core.Domains.Group", "Parent")
                        .WithMany("Parents")
                        .HasForeignKey("ParentGroupId");
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserGroup", b =>
                {
                    b.HasOne("fso.Core.Domains.Group", "Group")
                        .WithMany("UsersFollowing")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("FollowingGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserPostLike", b =>
                {
                    b.HasOne("fso.Core.Domains.Post", "Post")
                        .WithMany("LikedUsers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("fso.Core.Domains.UserInfo", "User")
                        .WithMany("PostLikes")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fso.Core.Domains.MMEntities.UserReview", b =>
                {
                    b.HasOne("fso.Core.Domains.Review", "Review")
                        .WithMany("UserLikes")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("LikedReviews")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fso.Core.Domains.Popularity", b =>
                {
                    b.HasOne("fso.Core.Domains.Group")
                        .WithMany("PopularityLevel")
                        .HasForeignKey("GroupId");

                    b.HasOne("fso.Core.Domains.Post")
                        .WithMany("Popularity")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("fso.Core.Domains.Post", b =>
                {
                    b.HasOne("fso.Core.Domains.PostCollection", "Collection")
                        .WithMany("Posts")
                        .HasForeignKey("CollectionId");

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("Posts")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("fso.Core.Domains.PostCollection", b =>
                {
                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("Collections")
                        .HasForeignKey("UserInfoId");
                });

            modelBuilder.Entity("fso.Core.Domains.PostPart", b =>
                {
                    b.HasOne("fso.Core.Domains.Post", "Post")
                        .WithMany("PostParts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("fso.Core.Domains.ReputationGain", b =>
                {
                    b.HasOne("fso.Core.Domains.Post", "Post")
                        .WithMany("ReputationGains")
                        .HasForeignKey("PostId");

                    b.HasOne("fso.Core.Domains.Review", "Review")
                        .WithMany("ReputationGains")
                        .HasForeignKey("ReviewId");

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("ReputationGains")
                        .HasForeignKey("UserInfoId");
                });

            modelBuilder.Entity("fso.Core.Domains.Review", b =>
                {
                    b.HasOne("fso.Core.Domains.Post", "Post")
                        .WithMany("Reviews")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("fso.Core.Domains.UserInfo", "UserInfo")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
